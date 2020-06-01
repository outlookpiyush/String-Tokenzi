using Tokenzi.Logic;

namespace Tokenzi.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            StringTokenziLogic stringTokenziLogic = new StringTokenziLogic();
            stringTokenziLogic.StrTokenzi("xyz abc mnp 'asdf dfaa asdf' asd 'fdas asdsadafF'");
        }
    }
}
