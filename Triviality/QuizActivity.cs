using Android.OS;
using Android.Widget;
using Android.App;
using System.Collections.Generic;
using Android;
using Android.Views;

namespace Triviality
{
	[Activity (Label = "Triviality", MainLauncher = true, Icon = "@drawable/icon")]
	public class QuizActivity : Activity
	{
		List<Question> quesList;
		int score=0;
		int qid=0;
		Question currentQ;
		TextView txtQuestion;
		RadioButton rda, rdb, rdc;
		Button butNext;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.QuizLayout);
			DbHelper db=new DbHelper(this);
			quesList=db.getAllQuestions();
			currentQ=quesList[qid];
			txtQuestion=(TextView)FindViewById(Resource.Id.textView1);
			rda=(RadioButton)FindViewById(Resource.Id.radio0);
			rdb=(RadioButton)FindViewById(Resource.Id.radio1);
			rdc=(RadioButton)FindViewById(Resource.Id.radio2);
			butNext=(Button)FindViewById(Resource.Id.button1);
			setQuestionView();
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.QuizMenu, menu);
			return true;
		}

		private void setQuestionView()
		{
			txtQuestion.Text = currentQ.getQUESTION();
			rda.Text = currentQ.getOPTA ();
			rdb.Text = currentQ.getOPTB ();
			rdc.Text = currentQ.getOPTC ();
			qid++;
		}
	}
}


