using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Text.RegularExpressions;
using Org.Webrtc;

namespace PeerNet
{
	public static class Util
	{
		/// <summary>
		/// The deafult host, in case it is not set while creating the peer
		/// </summary>
		public static string host = "0.peerjs.com";
		/// <summary>
		/// Default port where peer server operates
		/// </summary>
		public static int port = 9000;

		/// <summary>
		/// Returns a 16 letter alphanumeric random number.
		/// </summary>
		public static string token { 
			get {
				const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
				var random = new Random ();
				return new string (Enumerable.Repeat (chars, 16)
                  .Select (s => s [random.Next (s.Length)]).ToArray ());

			}
		}

		/// <summary>
		/// default configuration of a list of ICE/TURN server.Can be overridden while creating the peer.
		/// </summary>
		public static List<PeerConnection.IceServer> defaultConfig {
			get {
				var tempList = new List<PeerConnection.IceServer> ();
				tempList.Add (new PeerConnection.IceServer ("stun:stun.l.google.com:19302"));
				return tempList;
			}
		}

		/// <summary>
		/// Validate that the id is alphanumeric
		/// </summary>
		/// <param name="id">The id</param>
		/// <returns></returns>
		public static bool ValidateId (string id)
		{
			Regex regex = new Regex ("^[A-Za-z0-9]+(?:[ _-][A-Za-z0-9]+)*$");
			if (regex.IsMatch (id)) {
				return true;
			}
			return false;
            
		}

		/// <summary>
		/// Validate that the key is alphanumeric
		/// </summary>
		/// <param name="key">the key</param>
		/// <returns></returns>
		public static bool ValidateKey (string key)
		{
			Regex regex = new Regex ("^[A-Za-z0-9]+(?:[ _-][A-Za-z0-9]+)*$");
			if (regex.IsMatch (key)) {
				return true;
			}
			return false;
		}


	}
}