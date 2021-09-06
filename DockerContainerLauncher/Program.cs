using Docker.DotNet;
using Docker.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerContainerLauncher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DockerClient client = new DockerClientConfiguration(
                new Uri("unix:///var/run/docker.sock"))
                .CreateClient();

            // IList<ContainerListResponse> containers = await client.Containers.ListContainersAsync(
            //     new ContainersListParameters(){
            //         Limit = 10,
            //     });

            // foreach(var c in containers)
            // {
            //     foreach(var n in c.Names)
            //     {
            //         Console.WriteLine(n);
            //     }
            // }

            await client.Containers.StartContainerAsync(
                "0e2afbcb3d42",
                new ContainerStartParameters()
                );
        }
    }
}
