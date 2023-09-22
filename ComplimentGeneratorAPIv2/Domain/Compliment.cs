using MongoDB.Bson;
using System;

namespace ComplimentGeneratorAPIv2.Domain
{
	public class Compliment
	{
		public ObjectId Id { get; set; }
		public string Content { get; set; }
	}
}
