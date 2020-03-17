using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLshop.Data;
using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Data.Repositories;
using NLShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLshop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFacetory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Inittiallize()
        {
            dbFacetory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFacetory);
            unitOfWork = new UnitOfWork(dbFacetory);


        }
        [TestMethod]
        public void PostCatogory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test_Category";
            category.Alias = "Test_category";
            category.Status = true;
            PostCategory result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
