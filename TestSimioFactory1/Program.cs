using System;
using SimioAPI;

namespace TestSimioFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string simioExtensionPath = @"Extensions";

            SimioProjectFactory.SetExtensionsPath(simioExtensionPath);

        }
		
	}
}

