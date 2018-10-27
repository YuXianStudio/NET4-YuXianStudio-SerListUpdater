using System;
using System.IO;
using System.Net;

namespace NET4_Update_YuXStudio_ServerList
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverdat = ".minecraft/servers.dat";
            if (File.Exists(serverdat))
            {
                Console.WriteLine("  ");
                Console.WriteLine("  Copyright © 2019 YuxianStudio Organization All Rights Reserved. 使用有问题请联系:yuxianstudio@gmail.com");
                Console.WriteLine("  ");
                Console.WriteLine("  非常重要：请确保该程序在根目录下!!!");
                Console.WriteLine("  ");
                Console.WriteLine("  本程序带服务器列表备份功能，请放心享用");
                Console.WriteLine("  ");
                Console.WriteLine("  重要：是否更新服务器列表?");
                Console.WriteLine("  ");
                Console.WriteLine("  若“需要”更新，请按“回车”继续");
                Console.WriteLine("  若“无需”更新，请关闭该窗口");
                Console.ReadLine();
                FileInfo fileInfo = new FileInfo(@".minecraft\servers.dat");//读取文件信息
                Directory.CreateDirectory(@".minecraft\serversBackup\");//创建服务器列表备份文件夹
                File.Move(@".minecraft\servers.dat", @".minecraft\serversBackup\" + fileInfo.CreationTime.ToString("yyyy-MM-dd-HH-mm-ss——") + fileInfo.LastWriteTime.ToString("yyyy-MM-dd-HH-mm-ss_") + "servers.dat");//复制并重命名为服务器列表创建时间+最后修改时间
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraft-yuxianstudio-1252460563.cosgz.myqcloud.com/servers.dat", ".minecraft/servers.dat");
                Console.WriteLine("  下载servers.dat至/.minecraft目录完成!");
                Console.WriteLine("  更新服务器列表完成!");
                Console.WriteLine("  请按回车“关闭”窗口");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("  Copyright © 2019 YuxianStudio Organization All Rights Reserved. 使用有问题请联系:yuxianstudio@gmail.com");
                Console.WriteLine("  ");
                Console.WriteLine("  非常重要：请确保该程序在根目录下!!!");
                Console.WriteLine("  ");
                Console.WriteLine("  重要：是否下载服务器列表?");
                Console.WriteLine("  ");
                Console.WriteLine("  若“需要”下载，请按“回车”继续");
                Console.WriteLine("  若“无需”下载，请关闭该窗口");
                Console.ReadLine();
                WebClient webClient2 = new WebClient();
                webClient2.DownloadFile("https://minecraft-yuxianstudio-1252460563.cosgz.myqcloud.com/servers.dat", ".minecraft/servers.dat");
                Console.WriteLine("  下载servers.dat至/.minecraft目录完成!");
                Console.WriteLine("  下载服务器列表完成!");
                Console.WriteLine("  请按回车“关闭”窗口");
                Console.ReadLine();
            }
        }
    }
}