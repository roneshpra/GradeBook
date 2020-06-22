using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            var book1 =  GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        [Fact]
        public void TwovarscanReferenceSameObject()
        {
            var book1 =  GetBook("Book1");
            var book2 = book1;

           Assert.Same(book1, book2);
           Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void CanSetNameFromMethod()
        {
            var book1 =  GetBook("Book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

         [Fact]
        public void CsharpByValue()
        {
            var book1 =  GetBook("Book1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book=new Book(name);
        }

         [Fact]
        public void CsharpByRef()
        {
            var book1 =  GetBook("Book1");
            GetBookSetNamebyref(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNamebyref(ref Book book, string name)
        {
            book  = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}