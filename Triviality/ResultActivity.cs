using Android.OS;
using Android.App;
using Android.Widget;
using Android;
using Android.Views;

namespace Triviality
{
	public class ResultActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.ResultLayout);
			//get rating bar object
			RatingBar bar=(RatingBar)FindViewById(Resource.Id.ratingBar1); 
			bar.NumStars = 5;
			bar.StepSize = 0.5f;
			//get text view
			TextView t=(TextView)FindViewById(Resource.Id.textResult);
			//get score
			Bundle b = Intent.Extras;
			int score= b.GetInt("score");
			//display score
			bar.Rating = score;
			switch (score)
			{
			case 1:
			case 2: t.Text = "Opps, try again bro, keep learning";
				break;
			case 3:
			case 4:t.Text = "Hmmmm.. maybe you have been reading a lot of JasaProgrammer quiz";
				break;
			case 5:t.Text = "Who are you? A student in JP???";
				break;
			}
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.ResultMenu, menu);
			return true;
		}
	}
}

