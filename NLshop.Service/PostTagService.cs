using NLshop.Data.Infrastructure;
using NLShop.Data.Repositories;
using NLShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLshop.Service
{
 
        public interface IPostTagSevice
        {
            void Add(PostTag postTag);
            void Update(PostTag post);
            void Delete(int id);
            IEnumerable<PostTag> GetAll();
            PostTag GetById(int id);
        void SaveChanges();
        }
        public class PostTagSevice : IPostTagSevice
        {
            IPostTagRepository _postTagRepository;
            IUnitOfWork _unitOfWork;
            public void PostTagService(IPostTagRepository postTagRepository, IUnitOfWork unitOfWork)
            {
                this._postTagRepository = postTagRepository;
                this._unitOfWork = unitOfWork;
            }
            public void Add(PostTag postTag)
            {
                _postTagRepository.Add(postTag);
            }

            public void Delete(int id)
            {
                _postTagRepository.Delete(id);
            }

            public IEnumerable<PostTag> GetAll()
            {
                return _postTagRepository.GetAll(new string[] { "postTag" });
            }





            public PostTag GetById(int id)
            {
                return _postTagRepository.GetSingleById(id);
            }

            public void SaveChanges()
            {
                _unitOfWork.Commit();
            }

            public void Update(PostTag postTag)
            {
                _postTagRepository.Update(postTag);
            }

        PostTag IPostTagSevice.GetById(int id)
        {
            
               return _postTagRepository.GetSingleById(id);
            
        }
    }
    }
