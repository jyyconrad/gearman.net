//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Gearman.Packets.Worker;


namespace Gearman
{

	public class Job
	{
		private JobAssign jobPacket; 
		private Worker jobWorker; 
		
		public Job(JobAssign ja, Worker w)
		{
			this.jobPacket = ja; 
			this.jobWorker = w; 
		}
		
		public Worker worker {
			get {
				return jobWorker;
			}
			set {
				jobWorker = value;
			}
		}
		
		public void sendResults(byte[] results)
		{
			worker.connection.sendPacket(new WorkComplete(this.jobhandle, results));  
		}
		
		public void sendWorkUpdate(WorkStatus wspkt)
		{
			worker.connection.sendPacket(wspkt);				
		}
		
		
		public byte[] data { 
			get {
				return jobPacket.data;
			}
			
			set { 
				jobPacket.data = value;
			}
		}
		
		public string jobhandle {
			get { 
				return jobPacket.jobhandle;
			}
			
			set { 
				jobPacket.jobhandle = value;
			}
		}
		
		public string taskname { 
			get { 
				return jobPacket.taskname;
			}
			
			set { 
				jobPacket.taskname = value; 
			}
		}
		
	}

}
