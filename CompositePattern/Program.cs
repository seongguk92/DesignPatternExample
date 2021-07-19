using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folderJobFind = new Folder("취업");

            Folder folderIndividualProject = new Folder("개인프로젝트");
            Folder folderTeamProject = new Folder("팀프로젝트");

            folderJobFind.Add(folderIndividualProject);
            folderJobFind.Add(folderTeamProject);

            File fileJobPhoto  = new File("이력서 사진", 100);
            folderJobFind.Add(fileJobPhoto);

            Folder gameFolder = new Folder("게임");
            Folder serviceFolder = new Folder("서비스");

            File fileGameProposal = new File("게임 기획서", 300);
            File fileServiceProposal = new File("서비스 기획서", 4000);

            gameFolder.Add(fileGameProposal);
            serviceFolder.Add(fileServiceProposal);

            folderIndividualProject.Add(gameFolder);
            folderIndividualProject.Add(serviceFolder);

            Folder folderGoogleMap = new Folder("Google Map Project");
            File fileGoogleMapProposal = new File("구글 맵 기획서", 30000);
            folderGoogleMap.Add(fileGoogleMapProposal);

            folderTeamProject.Add(folderGoogleMap);

            folderJobFind.GetSize();
        }
    }
}
