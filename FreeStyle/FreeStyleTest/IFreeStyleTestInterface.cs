using System;

namespace FreeStyleTest
{
    public interface IFreeStyleTestInterface
    {
        void TestReadById();
        void TestSearch();
        void TestList();
        object TestCreate();
        void TestUpdate();
        void TestDelete();
    }
}
