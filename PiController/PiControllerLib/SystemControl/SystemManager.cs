using System;
using Unosquare.RaspberryIO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace PiControllerLib.SystemControl
{
	public class SystemManager
	{
		public List<IPAdapterInformation> IPAdapterInformationList = new List<IPAdapterInformation>();
		
		public string UpTime => SetUptimeString();//Pi.Info.UptimeTimeSpan.ToString();
		public string BoardModel => Pi.Info.BoardModel.ToString();
		public string ProcessorCount => Pi.Info.ProcessorCount.ToString();
		public string InstalledRam => Pi.Info.InstalledRam.ToString();
		public string OperatingSystem => Pi.Info.OperatingSystem.ToString();
		public string MemorySize => SetMemoryString();
		public SystemManager()
		{
			SetAdapterInformation();
			var os = Pi.Info.OperatingSystem;
/* 			Console.WriteLine(os.SysName);
			Console.WriteLine(os.DomainName);
			Console.WriteLine(os.Machine);
			Console.WriteLine(os.NodeName);
			Console.WriteLine(os.Release);
			Console.WriteLine(os.Version); */
		}

		private void SetAdapterInformation()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();

    		foreach (NetworkInterface adapter in nics)
    		{
				IPInterfaceProperties properties = adapter.GetIPProperties();
				IPAdapterInformationList.Add(new IPAdapterInformation(
					adapterType: adapter.Description.ToString(),
					interfaceType: adapter.NetworkInterfaceType.ToString(),
					operationalStatus: adapter.OperationalStatus.ToString(),
					ipAddress: properties?.UnicastAddresses?.FirstOrDefault()?.Address?.ToString(),
					dnsEnabled: properties.IsDnsEnabled.ToString()
				));
    		}
        }
		
		private string SetMemoryString()
		{
			string mem = Pi.Info.MemorySize.ToString();

			mem = $"{Regex.Replace(mem, "[^0-9]", "")}MB";
			
			return mem;
		}
		private string SetUptimeString()
		{
			var uptime = Pi.Info.UptimeTimeSpan;

			return $"{uptime.Days} days {uptime.Hours} hours {uptime.Minutes} minutes {uptime.Seconds} seconds {uptime.Milliseconds} milliseconds";
		}

	}

	public class IPAdapterInformation
	{
		public string AdapterType {get; private set;}
		public string InterfaceType {get; private set;}
		public string IPAddress {get; private set;}
		public string OperationalStatus {get; private set;}
		public string DNSEnabled {get; private set;}

		public IPAdapterInformation(string adapterType, 
									string interfaceType, 
									string ipAddress,
									string operationalStatus,
									string dnsEnabled)
		{
			AdapterType = adapterType;
			InterfaceType = interfaceType;
			IPAddress = ipAddress;
			OperationalStatus = operationalStatus;
			DNSEnabled = dnsEnabled;

			//PrintProperties();
		}

		public void PrintProperties()
		{
			Console.WriteLine(AdapterType);
			Console.WriteLine(InterfaceType);
			Console.WriteLine(IPAddress);
			Console.WriteLine(OperationalStatus);
			Console.WriteLine(DNSEnabled);
		}
	}
}
