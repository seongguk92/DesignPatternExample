using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Folder : IFileSystem
    {
        private string name;
        private List<IFileSystem> includeds = new List<IFileSystem>();

        public Folder(string name)
        {
            this.name = name;
        }

        public void Add(IFileSystem ifileSystem)
        {
            includeds.Add(ifileSystem);
        }

        public int GetSize()
        {
            int totalSize = 0;
            foreach (var included in includeds)
            {
                totalSize = totalSize + included.GetSize();
            }

            Console.WriteLine($"[{name}]폴더 크기 : {totalSize}");
            Console.WriteLine("- - - - -");
            
            return totalSize;
        }

        public void Remove()
        {
            foreach (var included in includeds)
            {
                included.Remove();
            }

            Console.WriteLine($"[{name}]폴더 삭제");
            Console.WriteLine("- - - - -");
        }
    }
}
