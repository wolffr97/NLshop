using AutoMapper;
using NLshop.Service;
using NLshop.Web.infratructure.Core;
using NLshop.Web.Models;
using NLShop.Model.Models;
using NLShop.Service;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.MobileControls;
using System.Windows.Documents;
using NLshop.Web.infratructure.Extentions;

namespace NLshop.Web.API
{
    [RoutePrefix("Api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postcategoryService;
        private IConfigurationProvider config;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postcategoryService = postCategoryService;
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage Response = null;
                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     PostCategory newPostCategory = new PostCategory();
                     newPostCategory.UpdatePostCategory(postCategoryVm);
                     _postcategoryService.Add(newPostCategory);
                     
                     _postcategoryService.Save();

                     Response = request.CreateResponse(HttpStatusCode.Created, newPostCategory);
                 }
                 return Response;
             });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage Response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVm);
                    _postcategoryService.Update(newPostCategory);

                    _postcategoryService.Save();

                    Response = request.CreateResponse(HttpStatusCode.OK);
                }
                return Response;
            });
        }
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage Response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postcategoryService.Delete(id);

                    _postcategoryService.Save();

                    Response = request.CreateResponse(HttpStatusCode.OK);
                }
                return Response;
            });
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listcategory = _postcategoryService.GetAll();

                var listPostCatagoryVm = Mapper.Map<List<PostCategoryViewModel>>(listcategory);

                HttpResponseMessage Response = request.CreateResponse(HttpStatusCode.OK, listPostCatagoryVm);

                return Response;
            });
        }
    }
}
