using NLshop.Model;
using NLshop.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NLshop.Web.infratructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }
        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMassage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage reponse = null;
            try
            {
                reponse = function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
                LogError(ex);
                reponse = requestMassage.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (DbUpdateException Dbex)
            {
                LogError(Dbex);
                reponse = requestMassage.CreateResponse(HttpStatusCode.BadRequest, Dbex.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                reponse = requestMassage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return reponse;
        }
        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Massage = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();

            }
            catch
            {

            }
        }
    }
}
