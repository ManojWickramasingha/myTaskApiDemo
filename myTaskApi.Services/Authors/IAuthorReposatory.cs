using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.Models;

namespace myTaskApi.Services.Authors
{
    public interface IAuthorReposatory
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int id);
    }
}
