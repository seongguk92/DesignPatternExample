using System;

namespace CompositePattern
{
    class File : IFileSystem
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }


        public int GetSize()
        {
            Console.WriteLine($"[{name}]파일 크기 : {size}");
            return size;
        }

        public void Remove()
        {
            Console.WriteLine($"[{name}]파일 삭제");
        }
    }
}
