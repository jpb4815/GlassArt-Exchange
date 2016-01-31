using System;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using DataAccessLayer.UnitofWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GlassPipesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           GlassPipesContext _ctx = new GlassPipesContext();

            Repository<Blog>  Blog = new Repository<Blog>(_ctx);
            UnitOfWork UoW = new UnitOfWork(_ctx);
            Blog.Insert(new Blog {  Content = "sdfkjghsdfghsdflkghdlgf", Date_Written = DateTime.Now, Title = "first"});
            UoW.Save();
           
        }
    }
}
