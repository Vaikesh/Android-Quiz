namespace Triviality
{
	public class Question
	{

		private int ID;
		private string QUESTION;
		private string OPTA;
		private string OPTB;
		private string OPTC;
		private string ANSWER;

		public Question ()
		{
			ID=0;
			QUESTION="";
			OPTA="";
			OPTB="";
			OPTC="";
			ANSWER="";
		}

		public Question(string qUESTION, string oPTA, string oPTB, string oPTC, string aNSWER)
		{
			QUESTION = qUESTION;
			OPTA = oPTA;
			OPTB = oPTB;
			OPTC = oPTC;
			ANSWER = aNSWER;
		}

		public int getID()
		{
			return ID;
		}

		public string getQUESTION()
		{
			return QUESTION;
		}

		public string getOPTA()
		{
			return OPTA;
		}

		public string getOPTB()
		{
			return OPTB;
		}

		public string getOPTC()
		{
			return OPTC;
		}

		public string getANSWER()
		{
			return ANSWER;
		}

		public void setID(int id)
		{
			ID=id;
		}

		public void setQUESTION(string qUESTION)
		{
			QUESTION = qUESTION;
		}

		public void setOPTA(string oPTA)
		{
			OPTA = oPTA;
		}

		public void setOPTB(string oPTB)
		{
			OPTB = oPTB;
		}

		public void setOPTC(string oPTC)
		{
			OPTC = oPTC;
		}

		public void setANSWER(string aNSWER)
		{
			ANSWER = aNSWER;
		}
	}
}