using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Renci.SshNet;

public static  class sshcommands  {

	public static string Ip;
	public static string username;
	public static string password;



	public static void my_qsub (string path, string name) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.RunCommand("cd " + path);
			client.RunCommand("qsub " + name);
			client.Disconnect();
		}
	}

	public static void my_cd (string path) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.RunCommand("cd " + path);
			client.Disconnect();
		}
	}

	public static void my_cp (string path_in, string path_ot, string name) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.RunCommand("cp " + path_in + name + " " + path_ot );
			client.Disconnect();
		}
	}

	public static void my_save_txt (string[] x, string path) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.Disconnect();
		}
	}

	public static void my_load_txt (string[] x, string path) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.Disconnect();
		}
	}

	public static void my_make_folder (string path, string name) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.RunCommand("cd " + path);
			client.Disconnect();
		}
	}

	public static void my_bzip_igf (string path) {
		using (var client = new SshClient(Ip, username, password))
		{
			client.Connect();
			client.RunCommand("cd " + path);
			client.RunCommand("bzip2 -dv " + path + "igf*");
			client.Disconnect();
		}
	}


}
