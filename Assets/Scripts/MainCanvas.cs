using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;


public class MainCanvas : MonoBehaviour
{
	
	public int counter;	
	public int counter2;
	public int correct; //for a 
	public int correct1; //for b
	public int correct2; //for c
	public int correct3; //for l

	public Canvas Canvas_intro;
	public Canvas Canvas_a;
	public Canvas Canvas_b;
	public Canvas Canvas_c;
	public Canvas Canvas_d;
	public Canvas Canvas_e;
	public Canvas Canvas_f;
	public Canvas Canvas_g;
	public Canvas Canvas_h;
	public Canvas Canvas_i;
	public Canvas Canvas_k; 
	public Canvas Canvas_l;
	public Canvas Canvas_m;
	public Canvas Canvas_n;
	public Canvas Canvas_o;
	public Canvas Canvas_p; 
	public Canvas Canvas_q;
	public Canvas Canvas_r;
	public Canvas Canvas_s;
	public Canvas Canvas_t;
	public Canvas Canvas_u;
	public Canvas Canvas_end;
	public Canvas Canvas_stage2intro;

	public Canvas Canvas_avid;
	public Canvas Canvas_cvid;
	public Canvas Canvas_bvid;
	public Canvas Canvas_lvid;

	public Canvas Canvas_Result_pos;
	public Canvas Canvas_Result_neg;

	public Canvas Canvas_imitateA;
	public Canvas Canvas_imitateB;
	public Canvas Canvas_imitateC;
	public Canvas Canvas_imitateL;

	public Canvas Canvas_underconstruction;
	public Canvas Canvas_stage2end;

	public GameObject forans; //fora
	public GameObject forb;
	public GameObject forc;
	public GameObject ford;
	public GameObject fore;
	public GameObject forf; 
	public GameObject forg;
	public GameObject forh;
	public GameObject fori;
	public GameObject fork;
	public GameObject forl;
	public GameObject form;
	public GameObject forn;
	public GameObject foro;
	public GameObject forp;
	public GameObject forq;
	public GameObject forr;
	public GameObject fors;
	public GameObject fort;
	public GameObject foru;

	public Camera mycamera;
	public Camera mycamerab;
	public Camera mycamerac;
	public Camera mycameral;

	/*public int[] adata = new int[5];
	public int[] cdata = new int[5];
	public int[] newadata = new int[5];
	public int[] newcdata = new int[5];
	//adata = new int[5];
	//cdata = new int[5];*/

	public Text txt;

	public float ib1x;
	public float ib1y;
	public float ib1z;
	
	public float ib2x;
	public float ib2y;
	public float ib2z;
	
	public float ib3x;
	public float ib3y;
	public float ib3z;
	
	public float mb1x;
	public float mb1y;
	public float mb1z;
	
	public float mb2x;
	public float mb2y;
	public float mb2z;
	
	public float mb3x;
	public float mb3y;
	public float mb3z;
	
	public float rb1x;
	public float rb1y;
	public float rb1z;

	public float rb2x;
	public float rb2y;
	public float rb2z;
	
	public float rb3x;
	public float rb3y;
	public float rb3z;
	
	public float pb1x;
	public float pb1y;
	public float pb1z;
	
	public float pb2x;
	public float pb2y;
	public float pb2z;
	
	public float pb3x;
	public float pb3y;
	public float pb3z;
	
	public float tb1x;
	public float tb1y;
	public float tb1z;
	
	public float tb2x;
	public float tb2y;
	public float tb2z;
	
	public float tb3x;
	public float tb3y;
	public float tb3z;
	
	
	
	
	// Use this for initialization
	void Start ()
		
	{
		counter = 0;//forans = GameObject.Find ("Input_ans");
		counter2 = 0;
		correct = 0; //for a
		correct1 = 0; //for b
		correct2 = 0; //for c
		correct3 = 0; //for l

		/*for (int i = 0; i <5; i++)
		{
			adata[i]= i;
			cdata[i]=i+1;
		
		}*/

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void Begin ()
	{
		Canvas_intro.gameObject.SetActive (false);
		Canvas_a.gameObject.SetActive (true);
		Debug.Log (counter);
	}

	public void stage2intro ()
	{
		Canvas_end.gameObject.SetActive (false);
		Canvas_stage2intro.gameObject.SetActive (true);
		Debug.Log (counter);

		}

	public void imitateA()
	{
		Canvas_stage2intro.gameObject.SetActive (false);
		Canvas_avid.gameObject.SetActive (true);
		Debug.Log (counter);
		}

	public void stopScript()
	{
		Canvas_avid.gameObject.SetActive (false);
		Canvas_imitateA.gameObject.SetActive (true);
	}

	public void stopScript2()
	{
		Canvas_cvid.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (true);
	}

	public void stopScript3()
	{
		Canvas_bvid.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (true);
	}

	public void stopScript4()
	{
		Canvas_lvid.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (true);
	}

	public void displayresults2()
	
	{

		/*for (int i = 0; i <5; i++)
		{
			newadata[i]= i;

		}

		for (int i = 0; i <5; i++)
		{
			if (adata[i] == newadata[i])
			{
				continue;
			}
			correct = 1;
			
		}

		Debug.Log (correct);
		//txt = Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct == 1) {
						
			txt.text = "Sorry wrong answer!";
				} else {
			txt.text = "Good job! correct answer";
				}*/
		ib1x = ForHandController.ib1x;
		ib1y = ForHandController.ib1y;
		ib1z = ForHandController.ib1z;
		
		ib2x = ForHandController.ib2x;
		ib2y = ForHandController.ib2y;
		ib2z = ForHandController.ib2z;
		
		ib3x= ForHandController.ib3x;
		ib3y= ForHandController.ib3y;
		ib3z= ForHandController.ib3z;
		
		mb1x= ForHandController.mb1x;
		mb1y= ForHandController.mb1y;
		mb1z= ForHandController.mb1z;
		
		mb2x= ForHandController.mb2x;
		mb2y= ForHandController.mb2y;
		mb2z= ForHandController.mb2z;
		
		mb3x= ForHandController.mb3x;
		mb3y= ForHandController.mb3y;
		mb3z= ForHandController.mb3z;
		
		rb1x = ForHandController.rb1x;
		rb1y = ForHandController.rb1y;
		rb1z = ForHandController.rb1z;
		
		rb2x = ForHandController.rb1x;
		rb2y = ForHandController.rb2y;
		rb2z = ForHandController.rb2z;
		
		rb3x = ForHandController.rb3x;
		rb3y = ForHandController.rb3y;
		rb3z = ForHandController.rb3z;
		
		pb1x= ForHandController.pb1x;
		pb1y= ForHandController.pb1y;
		pb1z= ForHandController.pb1z;
		
		pb2x= ForHandController.pb2x;
		pb2y= ForHandController.pb2y;
		pb2z= ForHandController.pb2z;
		
		pb3x= ForHandController.pb3x;
		pb3y= ForHandController.pb3y;
		pb3z= ForHandController.pb3z;
		
		tb1x= ForHandController.tb1x;
		tb1y= ForHandController.tb1y;
		tb1z= ForHandController.tb1z;
		
		tb2x= ForHandController.tb2x;
		tb2y= ForHandController.tb2y;
		tb2z= ForHandController.tb2z;
		
		tb3x= ForHandController.tb3x;
		tb3y= ForHandController.tb3y;
		tb3z= ForHandController.tb3z;

		using (StreamWriter sw = new StreamWriter("ParametersforA.txt")) {
			sw.WriteLine(ib1x);
			sw.WriteLine(ib1y);
			sw.WriteLine(ib1z);

			sw.WriteLine(ib2x);
			sw.WriteLine(ib2y);
			sw.WriteLine(ib2z);

			sw.WriteLine(ib3x);
			sw.WriteLine(ib3y);
			sw.WriteLine(ib3z);

			sw.WriteLine(mb1x);
			sw.WriteLine(mb1y);
			sw.WriteLine(mb1z);

			sw.WriteLine(mb2x);
			sw.WriteLine(mb2y);
			sw.WriteLine(mb2z);

			sw.WriteLine(mb3x);
			sw.WriteLine(mb3y);
			sw.WriteLine(mb3z);
		
			sw.WriteLine(rb1x);
			sw.WriteLine(rb1y);
			sw.WriteLine(rb1z);

			sw.WriteLine(rb2x);
			sw.WriteLine(rb2y);
			sw.WriteLine(rb2z);

			sw.WriteLine(rb3x);
			sw.WriteLine(rb3y);
			sw.WriteLine(rb3z);

			sw.WriteLine(pb1x);
			sw.WriteLine(pb1y);
			sw.WriteLine(pb1z);

			sw.WriteLine(pb2x);
			sw.WriteLine(pb2y);
			sw.WriteLine(pb2z);

			sw.WriteLine(pb3x);
			sw.WriteLine(pb3y);
			sw.WriteLine(pb3z);

			sw.WriteLine(tb1x);
			sw.WriteLine(tb1y);
			sw.WriteLine(tb1z);

			sw.WriteLine(tb2x);
			sw.WriteLine(tb2y);
			sw.WriteLine(tb2z);

			sw.WriteLine(tb3x);
			sw.WriteLine(tb3y);
			sw.WriteLine(tb3z);
		
				}



		string[] ParametersforL;// = new string[45];
		float[] ParametersforLm = new float[45];
		ParametersforL = System.IO.File.ReadAllLines(@"ParametersforA.txt");
		for (int i = 0; i<(ParametersforL.Length); i++)
		{
			ParametersforLm[i] = (float.Parse( ParametersforL[i])) ; //current frame values
		}

		string[] ParametersforLr;// = new string[45];
		float[] ParametersforLmr = new float[45];
		ParametersforLr = System.IO.File.ReadAllLines(@"ParametersforArecorded.txt");
		for (int i = 0; i<(ParametersforLr.Length); i++)
		{
			ParametersforLmr[i] = (float.Parse( ParametersforLr[i])); //recorded frame values
		}


		int error = 30;
		int corcount = 0;

		Debug.Log (ParametersforLm.Length);
		Debug.Log (Mathf.Abs(ParametersforLm[0]- ParametersforLmr[0]));


		for (int i = 0; i<(ParametersforLm.Length); i++)
		{
			if( Mathf.Abs(ParametersforLm[i]- ParametersforLmr[i])<error)//compare with error added
			{
				corcount++;
			}
			else if (( (360- Mathf.Max(ParametersforLm[i],ParametersforLmr[i]) )+(Mathf.Min(ParametersforLm[i],ParametersforLmr[i])))<error)
			{
				corcount++;
			}


		}

		Debug.Log (corcount);

		if (corcount <28)
		{
			correct = 1;
		}

		//txt = (Text) Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct == 1) 
		{	
			txt.text = "Sorry wrong answer!";
		} 
		else 
		{
			txt.text = "Good job! correct answer";
		}




		/*Debug.Log (ParametersforA[0]);
		Debug.Log (ParametersforA[1]);
		Debug.Log (ParametersforA[2]);
		Debug.Log (tb1x);
		Debug.Log (tb1y);
		Debug.Log (tb1z);*/



		Canvas_imitateA.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (false);
		Canvas_underconstruction.gameObject.SetActive (true);

		}


	public void displayresults3()
	
	{

		/*for (int i = 0; i <5; i++)
		{
			newadata[i]= i;

		}

		for (int i = 0; i <5; i++)
		{
			if (adata[i] == newadata[i])
			{
				continue;
			}
			correct = 1;
			
		}

		Debug.Log (correct);
		//txt = Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct == 1) {
						
			txt.text = "Sorry wrong answer!";
				} else {
			txt.text = "Good job! correct answer";
				}*/
		ib1x = ForHandController.ib1x;
		ib1y = ForHandController.ib1y;
		ib1z = ForHandController.ib1z;
		
		ib2x = ForHandController.ib2x;
		ib2y = ForHandController.ib2y;
		ib2z = ForHandController.ib2z;
		
		ib3x= ForHandController.ib3x;
		ib3y= ForHandController.ib3y;
		ib3z= ForHandController.ib3z;
		
		mb1x= ForHandController.mb1x;
		mb1y= ForHandController.mb1y;
		mb1z= ForHandController.mb1z;
		
		mb2x= ForHandController.mb2x;
		mb2y= ForHandController.mb2y;
		mb2z= ForHandController.mb2z;
		
		mb3x= ForHandController.mb3x;
		mb3y= ForHandController.mb3y;
		mb3z= ForHandController.mb3z;
		
		rb1x = ForHandController.rb1x;
		rb1y = ForHandController.rb1y;
		rb1z = ForHandController.rb1z;
		
		rb2x = ForHandController.rb1x;
		rb2y = ForHandController.rb2y;
		rb2z = ForHandController.rb2z;
		
		rb3x = ForHandController.rb3x;
		rb3y = ForHandController.rb3y;
		rb3z = ForHandController.rb3z;
		
		pb1x= ForHandController.pb1x;
		pb1y= ForHandController.pb1y;
		pb1z= ForHandController.pb1z;
		
		pb2x= ForHandController.pb2x;
		pb2y= ForHandController.pb2y;
		pb2z= ForHandController.pb2z;
		
		pb3x= ForHandController.pb3x;
		pb3y= ForHandController.pb3y;
		pb3z= ForHandController.pb3z;
		
		tb1x= ForHandController.tb1x;
		tb1y= ForHandController.tb1y;
		tb1z= ForHandController.tb1z;
		
		tb2x= ForHandController.tb2x;
		tb2y= ForHandController.tb2y;
		tb2z= ForHandController.tb2z;
		
		tb3x= ForHandController.tb3x;
		tb3y= ForHandController.tb3y;
		tb3z= ForHandController.tb3z;

		using (StreamWriter sw = new StreamWriter("ParametersforB.txt")) {
			sw.WriteLine(ib1x);
			sw.WriteLine(ib1y);
			sw.WriteLine(ib1z);

			sw.WriteLine(ib2x);
			sw.WriteLine(ib2y);
			sw.WriteLine(ib2z);

			sw.WriteLine(ib3x);
			sw.WriteLine(ib3y);
			sw.WriteLine(ib3z);

			sw.WriteLine(mb1x);
			sw.WriteLine(mb1y);
			sw.WriteLine(mb1z);

			sw.WriteLine(mb2x);
			sw.WriteLine(mb2y);
			sw.WriteLine(mb2z);

			sw.WriteLine(mb3x);
			sw.WriteLine(mb3y);
			sw.WriteLine(mb3z);
		
			sw.WriteLine(rb1x);
			sw.WriteLine(rb1y);
			sw.WriteLine(rb1z);

			sw.WriteLine(rb2x);
			sw.WriteLine(rb2y);
			sw.WriteLine(rb2z);

			sw.WriteLine(rb3x);
			sw.WriteLine(rb3y);
			sw.WriteLine(rb3z);

			sw.WriteLine(pb1x);
			sw.WriteLine(pb1y);
			sw.WriteLine(pb1z);

			sw.WriteLine(pb2x);
			sw.WriteLine(pb2y);
			sw.WriteLine(pb2z);

			sw.WriteLine(pb3x);
			sw.WriteLine(pb3y);
			sw.WriteLine(pb3z);

			sw.WriteLine(tb1x);
			sw.WriteLine(tb1y);
			sw.WriteLine(tb1z);

			sw.WriteLine(tb2x);
			sw.WriteLine(tb2y);
			sw.WriteLine(tb2z);

			sw.WriteLine(tb3x);
			sw.WriteLine(tb3y);
			sw.WriteLine(tb3z);
		
				}



		string[] ParametersforL;// = new string[45];
		float[] ParametersforLm = new float[45];
		ParametersforL = System.IO.File.ReadAllLines(@"ParametersforB.txt");
		for (int i = 0; i<(ParametersforL.Length); i++)
		{
			ParametersforLm[i] = (float.Parse( ParametersforL[i])) ; //current frame values
		}

		string[] ParametersforLr;// = new string[45];
		float[] ParametersforLmr = new float[45];
		ParametersforLr = System.IO.File.ReadAllLines(@"ParametersforBrecorded.txt");
		for (int i = 0; i<(ParametersforLr.Length); i++)
		{
			ParametersforLmr[i] = (float.Parse( ParametersforLr[i])); //recorded frame values
		}


		int error = 30;
		int corcount = 0;

		Debug.Log (ParametersforLm.Length);
		Debug.Log (Mathf.Abs(ParametersforLm[0]- ParametersforLmr[0]));


		for (int i = 0; i<(ParametersforLm.Length); i++)
		{
			if( Mathf.Abs(ParametersforLm[i]- ParametersforLmr[i])<error)//compare with error added
			{
				corcount++;
			}
			else if (( (360- Mathf.Max(ParametersforLm[i],ParametersforLmr[i]) )+(Mathf.Min(ParametersforLm[i],ParametersforLmr[i])))<error)
			{
				corcount++;
			}


		}

		Debug.Log (corcount);

		if (corcount <28)
		{
			correct1 = 1;
		}

		//txt = (Text) Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct1 == 1) 
		{	
			txt.text = "Sorry wrong answer!";
		} 
		else 
		{
			txt.text = "Good job! correct answer";
		}




		/*Debug.Log (ParametersforA[0]);
		Debug.Log (ParametersforA[1]);
		Debug.Log (ParametersforA[2]);
		Debug.Log (tb1x);
		Debug.Log (tb1y);
		Debug.Log (tb1z);*/



		Canvas_imitateA.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (false);
		Canvas_underconstruction.gameObject.SetActive (true);

		}


	public void displayresults4()
		
	{
		
		/*for (int i = 0; i <5; i++)
		{
			newadata[i]= i;

		}

		for (int i = 0; i <5; i++)
		{
			if (adata[i] == newadata[i])
			{
				continue;
			}
			correct = 1;
			
		}

		Debug.Log (correct);
		//txt = Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct == 1) {
						
			txt.text = "Sorry wrong answer!";
				} else {
			txt.text = "Good job! correct answer";
				}*/
		ib1x = ForHandController.ib1x;
		ib1y = ForHandController.ib1y;
		ib1z = ForHandController.ib1z;
		
		ib2x = ForHandController.ib2x;
		ib2y = ForHandController.ib2y;
		ib2z = ForHandController.ib2z;
		
		ib3x= ForHandController.ib3x;
		ib3y= ForHandController.ib3y;
		ib3z= ForHandController.ib3z;
		
		mb1x= ForHandController.mb1x;
		mb1y= ForHandController.mb1y;
		mb1z= ForHandController.mb1z;
		
		mb2x= ForHandController.mb2x;
		mb2y= ForHandController.mb2y;
		mb2z= ForHandController.mb2z;
		
		mb3x= ForHandController.mb3x;
		mb3y= ForHandController.mb3y;
		mb3z= ForHandController.mb3z;
		
		rb1x = ForHandController.rb1x;
		rb1y = ForHandController.rb1y;
		rb1z = ForHandController.rb1z;
		
		rb2x = ForHandController.rb1x;
		rb2y = ForHandController.rb2y;
		rb2z = ForHandController.rb2z;
		
		rb3x = ForHandController.rb3x;
		rb3y = ForHandController.rb3y;
		rb3z = ForHandController.rb3z;
		
		pb1x= ForHandController.pb1x;
		pb1y= ForHandController.pb1y;
		pb1z= ForHandController.pb1z;
		
		pb2x= ForHandController.pb2x;
		pb2y= ForHandController.pb2y;
		pb2z= ForHandController.pb2z;
		
		pb3x= ForHandController.pb3x;
		pb3y= ForHandController.pb3y;
		pb3z= ForHandController.pb3z;
		
		tb1x= ForHandController.tb1x;
		tb1y= ForHandController.tb1y;
		tb1z= ForHandController.tb1z;
		
		tb2x= ForHandController.tb2x;
		tb2y= ForHandController.tb2y;
		tb2z= ForHandController.tb2z;
		
		tb3x= ForHandController.tb3x;
		tb3y= ForHandController.tb3y;
		tb3z= ForHandController.tb3z;
		
		using (StreamWriter sw = new StreamWriter("ParametersforC.txt")) {
			sw.WriteLine(ib1x);
			sw.WriteLine(ib1y);
			sw.WriteLine(ib1z);
			
			sw.WriteLine(ib2x);
			sw.WriteLine(ib2y);
			sw.WriteLine(ib2z);
			
			sw.WriteLine(ib3x);
			sw.WriteLine(ib3y);
			sw.WriteLine(ib3z);
			
			sw.WriteLine(mb1x);
			sw.WriteLine(mb1y);
			sw.WriteLine(mb1z);
			
			sw.WriteLine(mb2x);
			sw.WriteLine(mb2y);
			sw.WriteLine(mb2z);
			
			sw.WriteLine(mb3x);
			sw.WriteLine(mb3y);
			sw.WriteLine(mb3z);
			
			sw.WriteLine(rb1x);
			sw.WriteLine(rb1y);
			sw.WriteLine(rb1z);
			
			sw.WriteLine(rb2x);
			sw.WriteLine(rb2y);
			sw.WriteLine(rb2z);
			
			sw.WriteLine(rb3x);
			sw.WriteLine(rb3y);
			sw.WriteLine(rb3z);
			
			sw.WriteLine(pb1x);
			sw.WriteLine(pb1y);
			sw.WriteLine(pb1z);
			
			sw.WriteLine(pb2x);
			sw.WriteLine(pb2y);
			sw.WriteLine(pb2z);
			
			sw.WriteLine(pb3x);
			sw.WriteLine(pb3y);
			sw.WriteLine(pb3z);
			
			sw.WriteLine(tb1x);
			sw.WriteLine(tb1y);
			sw.WriteLine(tb1z);
			
			sw.WriteLine(tb2x);
			sw.WriteLine(tb2y);
			sw.WriteLine(tb2z);
			
			sw.WriteLine(tb3x);
			sw.WriteLine(tb3y);
			sw.WriteLine(tb3z);
			
		}
		
		
		
		string[] ParametersforL;// = new string[45];
		float[] ParametersforLm = new float[45];
		ParametersforL = System.IO.File.ReadAllLines(@"ParametersforC.txt");
		for (int i = 0; i<(ParametersforL.Length); i++)
		{
			ParametersforLm[i] = (float.Parse( ParametersforL[i])) ; //current frame values
		}
		
		string[] ParametersforLr;// = new string[45];
		float[] ParametersforLmr = new float[45];
		ParametersforLr = System.IO.File.ReadAllLines(@"ParametersforCrecorded.txt");
		for (int i = 0; i<(ParametersforLr.Length); i++)
		{
			ParametersforLmr[i] = (float.Parse( ParametersforLr[i])); //recorded frame values
		}
		
		
		int error = 30;
		int corcount = 0;
		
		Debug.Log (ParametersforLm.Length);
		Debug.Log (Mathf.Abs(ParametersforLm[0]- ParametersforLmr[0]));
		
		
		for (int i = 0; i<(ParametersforLm.Length); i++)
		{
			if( Mathf.Abs(ParametersforLm[i]- ParametersforLmr[i])<error)//compare with error added
			{
				corcount++;
			}
			else if (( (360- Mathf.Max(ParametersforLm[i],ParametersforLmr[i]) )+(Mathf.Min(ParametersforLm[i],ParametersforLmr[i])))<error)
			{
				corcount++;
			}
			
			
		}
		
		Debug.Log (corcount);
		
		if (corcount <28)
		{
			correct2 = 1;
		}
		
		//txt = (Text) Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct2 == 1) 
		{	
			txt.text = "Sorry wrong answer!";
		} 
		else 
		{
			txt.text = "Good job! correct answer";
		}
		
		
		
		
		/*Debug.Log (ParametersforA[0]);
		Debug.Log (ParametersforA[1]);
		Debug.Log (ParametersforA[2]);
		Debug.Log (tb1x);
		Debug.Log (tb1y);
		Debug.Log (tb1z);*/
		
		
		
		Canvas_imitateA.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (false);
		Canvas_underconstruction.gameObject.SetActive (true);
		
	}

	public void displayresults5()
		
	{
		
		/*for (int i = 0; i <5; i++)
		{
			newadata[i]= i;

		}

		for (int i = 0; i <5; i++)
		{
			if (adata[i] == newadata[i])
			{
				continue;
			}
			correct = 1;
			
		}

		Debug.Log (correct);
		//txt = Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct == 1) {
						
			txt.text = "Sorry wrong answer!";
				} else {
			txt.text = "Good job! correct answer";
				}*/
		ib1x = ForHandController.ib1x;
		ib1y = ForHandController.ib1y;
		ib1z = ForHandController.ib1z;
		
		ib2x = ForHandController.ib2x;
		ib2y = ForHandController.ib2y;
		ib2z = ForHandController.ib2z;
		
		ib3x= ForHandController.ib3x;
		ib3y= ForHandController.ib3y;
		ib3z= ForHandController.ib3z;
		
		mb1x= ForHandController.mb1x;
		mb1y= ForHandController.mb1y;
		mb1z= ForHandController.mb1z;
		
		mb2x= ForHandController.mb2x;
		mb2y= ForHandController.mb2y;
		mb2z= ForHandController.mb2z;
		
		mb3x= ForHandController.mb3x;
		mb3y= ForHandController.mb3y;
		mb3z= ForHandController.mb3z;
		
		rb1x = ForHandController.rb1x;
		rb1y = ForHandController.rb1y;
		rb1z = ForHandController.rb1z;
		
		rb2x = ForHandController.rb1x;
		rb2y = ForHandController.rb2y;
		rb2z = ForHandController.rb2z;
		
		rb3x = ForHandController.rb3x;
		rb3y = ForHandController.rb3y;
		rb3z = ForHandController.rb3z;
		
		pb1x= ForHandController.pb1x;
		pb1y= ForHandController.pb1y;
		pb1z= ForHandController.pb1z;
		
		pb2x= ForHandController.pb2x;
		pb2y= ForHandController.pb2y;
		pb2z= ForHandController.pb2z;
		
		pb3x= ForHandController.pb3x;
		pb3y= ForHandController.pb3y;
		pb3z= ForHandController.pb3z;
		
		tb1x= ForHandController.tb1x;
		tb1y= ForHandController.tb1y;
		tb1z= ForHandController.tb1z;
		
		tb2x= ForHandController.tb2x;
		tb2y= ForHandController.tb2y;
		tb2z= ForHandController.tb2z;
		
		tb3x= ForHandController.tb3x;
		tb3y= ForHandController.tb3y;
		tb3z= ForHandController.tb3z;
		
		using (StreamWriter sw = new StreamWriter("ParametersforL.txt")) {
			sw.WriteLine(ib1x);
			sw.WriteLine(ib1y);
			sw.WriteLine(ib1z);
			
			sw.WriteLine(ib2x);
			sw.WriteLine(ib2y);
			sw.WriteLine(ib2z);
			
			sw.WriteLine(ib3x);
			sw.WriteLine(ib3y);
			sw.WriteLine(ib3z);
			
			sw.WriteLine(mb1x);
			sw.WriteLine(mb1y);
			sw.WriteLine(mb1z);
			
			sw.WriteLine(mb2x);
			sw.WriteLine(mb2y);
			sw.WriteLine(mb2z);
			
			sw.WriteLine(mb3x);
			sw.WriteLine(mb3y);
			sw.WriteLine(mb3z);
			
			sw.WriteLine(rb1x);
			sw.WriteLine(rb1y);
			sw.WriteLine(rb1z);
			
			sw.WriteLine(rb2x);
			sw.WriteLine(rb2y);
			sw.WriteLine(rb2z);
			
			sw.WriteLine(rb3x);
			sw.WriteLine(rb3y);
			sw.WriteLine(rb3z);
			
			sw.WriteLine(pb1x);
			sw.WriteLine(pb1y);
			sw.WriteLine(pb1z);
			
			sw.WriteLine(pb2x);
			sw.WriteLine(pb2y);
			sw.WriteLine(pb2z);
			
			sw.WriteLine(pb3x);
			sw.WriteLine(pb3y);
			sw.WriteLine(pb3z);
			
			sw.WriteLine(tb1x);
			sw.WriteLine(tb1y);
			sw.WriteLine(tb1z);
			
			sw.WriteLine(tb2x);
			sw.WriteLine(tb2y);
			sw.WriteLine(tb2z);
			
			sw.WriteLine(tb3x);
			sw.WriteLine(tb3y);
			sw.WriteLine(tb3z);
			
		}
		
		
		
		string[] ParametersforL;// = new string[45];
		float[] ParametersforLm = new float[45];
		ParametersforL = System.IO.File.ReadAllLines(@"ParametersforL.txt");
		for (int i = 0; i<(ParametersforL.Length); i++)
		{
			ParametersforLm[i] = (float.Parse( ParametersforL[i])) ; //current frame values
		}
		
		string[] ParametersforLr;// = new string[45];
		float[] ParametersforLmr = new float[45];
		ParametersforLr = System.IO.File.ReadAllLines(@"ParametersforLrecorded.txt");
		for (int i = 0; i<(ParametersforLr.Length); i++)
		{
			ParametersforLmr[i] = (float.Parse( ParametersforLr[i])); //recorded frame values
		}
		
		
		int error = 30;
		int corcount = 0;
		
		Debug.Log (ParametersforLm.Length);
		Debug.Log (Mathf.Abs(ParametersforLm[0]- ParametersforLmr[0]));
		
		
		for (int i = 0; i<(ParametersforLm.Length); i++)
		{
			if( Mathf.Abs(ParametersforLm[i]- ParametersforLmr[i])<error)//compare with error added
			{
				corcount++;
			}
			else if (( (360- Mathf.Max(ParametersforLm[i],ParametersforLmr[i]) )+(Mathf.Min(ParametersforLm[i],ParametersforLmr[i])))<error)
			{
				corcount++;
			}
			
			
		}
		
		Debug.Log (corcount);
		
		if (corcount <28)
		{
			correct3 = 1;
		}
		
		//txt = (Text) Canvas_underconstruction.gameObject.GetComponent<Text> (); 
		if (correct3 == 1) 
		{	
			txt.text = "Sorry wrong answer!";
		} 
		else 
		{
			txt.text = "Good job! correct answer";
		}
		
		
		
		
		/*Debug.Log (ParametersforA[0]);
		Debug.Log (ParametersforA[1]);
		Debug.Log (ParametersforA[2]);
		Debug.Log (tb1x);
		Debug.Log (tb1y);
		Debug.Log (tb1z);*/
		
		
		
		Canvas_imitateA.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (false);
		Canvas_underconstruction.gameObject.SetActive (true);
		
	}

	
	
	
	public void Next () //a
	{
		Text t = forans.GetComponent<Text> ();
		if ((t.text == "a") ||(t.text == "A")) {
			Debug.Log ("success");
			
			
			Canvas_a.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_a.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextb ()
	{
		Text t1 = forb.GetComponent<Text> ();
		Debug.Log (t1.text);
		if ((t1.text == "b") ||(t1.text == "B")) {
			Debug.Log ("successs");
			
			
			Canvas_b.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_b.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextc ()
	{
		Text t2 = forc.GetComponent<Text> ();
		Debug.Log (t2.text);
		if ((t2.text == "c") ||(t2.text == "C")) {
			Debug.Log ("successs");
			
			
			Canvas_c.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_c.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	public void Nextd ()
	{
		Text t3 = ford.GetComponent<Text> ();
		Debug.Log (t3.text);
		if ((t3.text == "d") ||(t3.text == "D")) {
			Debug.Log ("successs");
			
			
			Canvas_d.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_d.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nexte ()
	{
		Text t4 = fore.GetComponent<Text> ();
		Debug.Log (t4.text);
		if ((t4.text == "e") ||(t4.text == "E")) {
			Debug.Log ("successs");
			
			
			Canvas_e.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_e.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextf ()
	{
		Text t5 = forf.GetComponent<Text> ();
		Debug.Log (t5.text);
		if ((t5.text == "f") ||(t5.text == "F")) {
			Debug.Log ("successs");
			
			
			Canvas_f.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_f.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextg ()
	{
		Text t6 = forg.GetComponent<Text> ();
		Debug.Log (t6.text);
		if ((t6.text == "g") ||(t6.text == "G")) {
			Debug.Log ("successs");
			
			
			Canvas_g.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_g.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nexth ()
	{
		Text t7 = forh.GetComponent<Text> ();
		Debug.Log (t7.text);
		if ((t7.text == "h") ||(t7.text == "H")) {
			Debug.Log ("successs");
			
			
			Canvas_h.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_h.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	
	public void Nexti ()
	{
		Text t8 = forh.GetComponent<Text> ();
		Debug.Log (t8.text);
		if ((t8.text == "i") ||(t8.text == "I")) {
			Debug.Log ("successs");
			
			
			Canvas_i.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_i.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextk ()
	{
		Text t9 = fork.GetComponent<Text> ();
		Debug.Log (t9.text);
		if ((t9.text == "k") ||(t9.text == "K")) {
			Debug.Log ("successs");
			
			
			Canvas_k.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_k.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextl ()
	{
		Text t10 = forl.GetComponent<Text> ();
		Debug.Log (t10.text);
		if ((t10.text == "l") ||(t10.text == "L")) {
			Debug.Log ("successs");
			
			
			Canvas_l.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_l.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	
	public void Nextm ()
	{
		Text t11 = form.GetComponent<Text> ();
		Debug.Log (t11.text);
		if ((t11.text == "m") ||(t11.text == "M")) {
			Debug.Log ("successs");
			
			
			Canvas_m.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_m.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextn ()
	{
		Text t12 = forn.GetComponent<Text> ();
		Debug.Log (t12.text);
		if ((t12.text == "n") ||(t12.text == "N")) {
			Debug.Log ("successs");
			
			
			Canvas_n.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_n.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nexto ()
	{
		Text t13 = foro.GetComponent<Text> ();
		Debug.Log (t13.text);
		if ((t13.text == "o") ||(t13.text == "O")) {
			Debug.Log ("successs");
			
			
			Canvas_o.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_o.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextp ()
	{
		Text t14 = forp.GetComponent<Text> ();
		Debug.Log (t14.text);
		if ((t14.text == "p") ||(t14.text == "P")) {
			Debug.Log ("successs");
			
			
			Canvas_p.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_p.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextqq ()
	{
		Text t15 = forq.GetComponent<Text> ();
		Debug.Log (t15.text);
		if ((t15.text == "q") ||(t15.text == "Q")) {
			Debug.Log ("successs");
			
			
			Canvas_q.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_q.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextr ()
	{
		Text t16 = forr.GetComponent<Text> ();
		Debug.Log (t16.text);
		if ((t16.text == "r") ||(t16.text == "R")) {
			Debug.Log ("successs");
			
			
			Canvas_r.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_r.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nexts ()
	{
		Text t17 = fors.GetComponent<Text> ();
		Debug.Log (t17.text);
		if ((t17.text == "s") ||(t17.text == "S")) {
			Debug.Log ("successs");
			
			
			Canvas_s.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_s.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextt ()
	{
		Text t18 = fort.GetComponent<Text> ();
		Debug.Log (t18.text);
		if ((t18.text == "t") ||(t18.text == "T")) {
			Debug.Log ("successs");
			
			
			Canvas_t.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_t.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	public void Nextu ()
	{
		Text t19 = foru.GetComponent<Text> ();
		Debug.Log (t19.text);
		if ((t19.text == "u") ||(t19.text == "U")) {
			Debug.Log ("successs");
			
			
			Canvas_u.gameObject.SetActive (false);
			Canvas_Result_pos.gameObject.SetActive (true);
		}  else {
			Debug.Log ("failure");
			
			
			Canvas_u.gameObject.SetActive (false);
			Canvas_Result_neg.gameObject.SetActive (true);
		}
	}
	
	
	
	
	public void Nextq ()
	{
		Canvas_Result_pos.gameObject.SetActive (false);
		Canvas_Result_neg.gameObject.SetActive (false);
		counter++;
		if (counter == 1) {
						Debug.Log (counter);
						Canvas_u.gameObject.SetActive (true);
				} else if (counter == 2) {
						Debug.Log (counter);
						Canvas_b.gameObject.SetActive (true);
				} else if (counter == 3) {
						Debug.Log (counter);
						Canvas_t.gameObject.SetActive (true);
				} else if (counter == 4) {
						Debug.Log (counter);
						Canvas_c.gameObject.SetActive (true);
				} else if (counter == 5) {
						Debug.Log (counter);
						Canvas_s.gameObject.SetActive (true);
				} else if (counter == 6) {
						Debug.Log (counter);
						Canvas_d.gameObject.SetActive (true);
				} else if (counter == 7) {
						Debug.Log (counter);
						Canvas_r.gameObject.SetActive (true);
				} else if (counter == 8) {
						Debug.Log (counter);
						Canvas_e.gameObject.SetActive (true);
				} else if (counter == 9) {
						Debug.Log (counter);
						Canvas_q.gameObject.SetActive (true);
				} else if (counter == 10) {
						Debug.Log (counter);
						Canvas_f.gameObject.SetActive (true);
				} else if (counter == 11) {
						Debug.Log (counter);
						Canvas_p.gameObject.SetActive (true);
				} else if (counter == 12) {
						Debug.Log (counter);
						Canvas_g.gameObject.SetActive (true);
				} else if (counter == 13) {
						Debug.Log (counter);
						Canvas_o.gameObject.SetActive (true);
				} else if (counter == 14) {
						Debug.Log (counter);
						Canvas_h.gameObject.SetActive (true);
				} else if (counter == 15) {
						Debug.Log (counter);
						Canvas_n.gameObject.SetActive (true);
				} else if (counter == 16) {
						Debug.Log (counter);
						Canvas_i.gameObject.SetActive (true);
				} else if (counter == 17) {
						Debug.Log (counter);
						Canvas_m.gameObject.SetActive (true);
				} else if (counter == 18) {
						Debug.Log (counter);
						Canvas_k.gameObject.SetActive (true);
				} else if (counter == 19) {
						Debug.Log (counter);
						Canvas_l.gameObject.SetActive (true);
				} else if (counter == 20) {
			Debug.Log (counter);
			Canvas_end.gameObject.SetActive(true);
				}
		
		
		
	}

	public void NextGesture ()
	{
		Canvas_underconstruction.gameObject.SetActive (false);
	
		counter2++;
		if (counter2 == 1) {
			Debug.Log (counter);
			Canvas_cvid.gameObject.SetActive (true);
		} 
		else if (counter2 == 2)
		{
			Debug.Log (counter);
			Canvas_bvid.gameObject.SetActive(true);
		}
		else if (counter2 == 3)
		{
			Debug.Log (counter);
			Canvas_lvid.gameObject.SetActive(true);

		}
		else if (counter2 == 4)
		{
			Debug.Log (counter);
			Canvas_stage2end.gameObject.SetActive(true);
		}
		
		
		
	}
	
	public void exit ()
	{
		Canvas_intro.gameObject.SetActive (false);
		Canvas_Result_pos.gameObject.SetActive (false);
		Canvas_Result_neg.gameObject.SetActive (false);
		Canvas_a.gameObject.SetActive (false);
		Canvas_b.gameObject.SetActive (false);
		Canvas_c.gameObject.SetActive (false);
		Canvas_d.gameObject.SetActive (false);
		Canvas_e.gameObject.SetActive (false);
		Canvas_f.gameObject.SetActive (false);
		Canvas_g.gameObject.SetActive (false);
		Canvas_h.gameObject.SetActive (false);
		Canvas_i.gameObject.SetActive (false);
		Canvas_k.gameObject.SetActive (false);
		Canvas_l.gameObject.SetActive (false);
		Canvas_m.gameObject.SetActive (false);
		Canvas_n.gameObject.SetActive (false);
		Canvas_o.gameObject.SetActive (false);
		Canvas_p.gameObject.SetActive (false);
		Canvas_q.gameObject.SetActive (false);
		Canvas_r.gameObject.SetActive (false);
		Canvas_t.gameObject.SetActive (false);
		Canvas_u.gameObject.SetActive (false);

		Canvas_end.gameObject.SetActive (false);
		Canvas_stage2intro.gameObject.SetActive (false);
		Canvas_avid.gameObject.SetActive (false);
		Canvas_cvid.gameObject.SetActive (false);
		Canvas_bvid.gameObject.SetActive (false);
		Canvas_lvid.gameObject.SetActive (false);
		Canvas_Result_pos.gameObject.SetActive (false);
		Canvas_Result_neg.gameObject.SetActive (false);
		Canvas_imitateA.gameObject.SetActive (false);
		Canvas_imitateB.gameObject.SetActive (false);
		Canvas_imitateC.gameObject.SetActive (false);
		Canvas_imitateL.gameObject.SetActive (false);
		Canvas_underconstruction.gameObject.SetActive (false);
		Canvas_stage2end.gameObject.SetActive (false);
		
	}
	
}








