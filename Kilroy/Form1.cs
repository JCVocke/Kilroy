using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kilroy
{
    public partial class Form1 : Form
    {
        public string appPath = "";
        public string modPath = "";
        public string modFile = @"mods_registry.json";
        public string ordFile = @"game_data.json";
        public string lodFile = @"dlc_load.json";

        public bool EULAShit = false;

        int gSEL = 0;
        List<string> gNAM;
        List<string> gUID;

        List<string> mALL;
        List<string> mACT;
        Dictionary<string, WithPartsMadeInJapan> mLST;
        Dictionary<string, string> mMID;
        Dictionary<string, string> mNAM;

        string iDLC = "";
        string iMOD = "";

        bool GasGasGASImGonnaStepOnTheGasTONIGHT = false;

        public Form1()
        {
            InitializeComponent();

            appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\";
            modPath = appPath + @"mod\";

            gNAM = new List<string>() { "Stellaris", "Europa Universalis IV" };
            gUID = new List<string>() { "", "" };
            //MessageBox.Show(appPath);
            //MessageBox.Show(modPath);

            mALL = new List<string>();
            mACT = new List<string>();
            mLST = new Dictionary<string, WithPartsMadeInJapan>();
            mMID = new Dictionary<string, string>();
            mNAM = new Dictionary<string, string>();

            YoureWonderingWHoIAm();
            ToThrowAwayThisMask();
			//MataAuHimaDe();
			IAmTheModernMan();
        }

            //IO
	    private static List<string> ExtractFromBody(string body, string start, string end)
	    {
	        List<string> matched = new List<string>();
	
	        int indexStart = 0;
	        int indexEnd = 0;
	
	        bool exit = false;
	        while (!exit)
	        {
	            indexStart = body.IndexOf(start);
	            if (indexStart != -1)
	            {
	                indexEnd = indexStart + body.Substring(indexStart + start.Length).IndexOf(end) + start.Length;	
	                matched.Add(body.Substring(indexStart + start.Length, indexEnd - indexStart - start.Length));
	                body = body.Substring(indexEnd + end.Length);
	            }
	            else
	            {
	                exit = true;
	            }
	        }
	
	        return matched;
	    }
		private void MataAuHimaDe()
        {
            /*
            //dlc_load.json
			string lFUL = "";
			List<string> lEXT = new List<string>();

			using (StreamReader sr = new StreamReader(appPath + lodFile))
			{
				string line = "";
                while ((line = sr.ReadLine()) != null)
                {
					List<string> lSRT = ExtractFromBody(line, @"[", @"]");
					lEXT.AddRange(lSRT);
				}
			}

			if(lEXT.Count==2)
			{
				iDLC = lEXT[0];
				iMOD = lEXT[1];
			}

			List<string> iMODs = new List<string>();
			iMODs.AddRange(iMOD.Split(','));
			mACT.Clear();
			foreach(string s in iMODs)
			{ 
				string sPP = s.Replace("\"","").Replace(@"mod/", "");
				mACT.Add(sPP); 
			}
			IAmTheModernMan();
            */
            YoureWonderingWHoIAm();
		}
		private void HimitsuWoShiriTai()
        {
            //game_data.json
            string mFUL = "";
            //dlc_load.json
            string lFUL = "";

			bool fALL = false;
			bool fACT = false;

            mFUL = "{\"modsOrder\":[";
            lFUL = "{\"disabled_dlcs\":[" + iDLC + "],\"enabled_mods\":[";
            for (int i = 0; i < mALL.Count; i++)
            {
                if (fALL) { mFUL += ","; }
                mFUL += "\"" + mLST[mALL[i]].UID + "\"";
				fALL = true;

                if (mACT.Contains(mALL[i]))
                {
                    if (fACT) { lFUL += ","; }
                    lFUL += "\"" + @"mod/" + mLST[mALL[i]].MID + "\"";
					fACT = true;
                }
            }
            mFUL += "],";
            mFUL += "\"isEulaAccepted\":";
            if (EULAShit) { mFUL += "true"; }
            else { mFUL += "false"; }
            mFUL += "}";
            lFUL += "]}";

            using (StreamWriter sr = new StreamWriter(appPath + ordFile))
            {
                sr.WriteLine(mFUL);
            }

			using (StreamWriter sr = new StreamWriter(appPath + lodFile))
			{
				sr.WriteLine(lFUL);
            }
		}

			//Stuff
        private void YoureWonderingWHoIAm()
        {
            mLST.Clear();
            mMID.Clear();
            mNAM.Clear();
            mALL.Clear();
            mACT.Clear();

            //mods_registry.json
            if (System.IO.File.Exists(appPath + modFile))
            {
				string modsAllForOne = "";
                List<string> modsALL = new List<string>();
                using (StreamReader sr = new StreamReader(appPath + modFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        modsAllForOne+=line;
                    }
                }
					//Clean up extra spaces and other formatting quirks
				modsAllForOne = modsAllForOne.Replace(@"}}", @"},}");
				while(modsAllForOne.Contains(": ")) { modsAllForOne = modsAllForOne.Replace(@": ", @":"); }
				while(modsAllForOne.Contains("/ ")) { modsAllForOne = modsAllForOne.Replace(@"/ ", @"/"); }
				while(modsAllForOne.Contains(", ")) { modsAllForOne = modsAllForOne.Replace(@", ", @","); }
				//while(modsAllForOne.Contains("/ ")) { modsAllForOne = modsAllForOne.Replace("\" ", "\""); }
				//while(modsAllForOne.Contains("/ ")) { modsAllForOne = modsAllForOne.Replace(" \"", "\""); }
				modsALL.AddRange(ExtractFromBody(modsAllForOne, @":{", @"},"));
                foreach (string s in modsALL)
                {
                    WithPartsMadeInJapan KROY = MachineOrMannequin(s);
                    mLST.Add(KROY.UID, KROY);
					if(mMID.ContainsKey(KROY.MID)) { /*MessageBox.Show(KROY.MID + "-" + KROY.UID);*/ }
                    else { mMID.Add(KROY.MID, KROY.UID); }
                    if (mNAM.ContainsKey(KROY.NAM)) { /*MessageBox.Show(KROY.NAM);*/ }
                    else { mNAM.Add(KROY.NAM, KROY.UID); }
                }
            }

            //game_data.json
            if (System.IO.File.Exists(appPath + ordFile))
            {
                List<string> ordALL = new List<string>();
                using (StreamReader sr = new StreamReader(appPath + ordFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string EULA = (ExtractFromBody(line, "isEulaAccepted\":", @"}"))[0];
                        if (EULA.ToLower() == "true") { EULAShit = true; }

                        string ordEXT = (ExtractFromBody(line, @":[", @"]"))[0];
                        ordALL.AddRange(ordEXT.Split(','));
                        
                    }
                }
                foreach (string s in ordALL)
                {
                    if (mLST.ContainsKey(s.Replace("\"", ""))) { mALL.Add(s.Replace("\"", "")); }
                }
            }
            else
            {
				foreach(string s in mLST.Keys)
				{
					mALL.Add(s);
				}
            }
            
            //dlc_load.json
            if (System.IO.File.Exists(appPath + lodFile))
            {
                List<string> lEXT = new List<string>();
                using (StreamReader sr = new StreamReader(appPath + lodFile))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        List<string> lSRT = ExtractFromBody(line, @"[", @"]");
                        lEXT.AddRange(lSRT);
                    }
                }

                if (lEXT.Count == 2)
                {
                    iDLC = lEXT[0];
                    iMOD = lEXT[1];
                }

                List<string> iMODs = new List<string>();
                iMODs.AddRange(iMOD.Split(','));
                foreach (string s in iMODs)
                {
                    string sPP = s.Replace("\"", "").Replace(@"mod/", "");
                    if (mMID.ContainsKey(sPP))
                    {
                        mACT.Add(mMID[sPP]);
                    }
                }
            }

            IAmTheModernMan();
        }
        private WithPartsMadeInJapan MachineOrMannequin(string inf)
        {
            string typ = "L"; //Default to a Local Mod
            string uid = "";
            string mid = "";
            string sid = "";
            string nam = "";
            string ver = "";

					//MessageBox.Show(inf);
            string[] sSPL = inf.Split(',');
            foreach (string s in sSPL)
            {
					//MessageBox.Show(s);
                if (s.Contains("steamId")) { typ = "S"; sid = s.Replace("\"steamId\":", "").Replace("\"", ""); } //If a SteamID is present, set type to Steam
                if (s.Contains("\"id\":")) { uid = s.Replace("\"id\":", "").Replace("\"", ""); }
                if (s.Contains("\"gameRegistryId\":")) { mid = s.Replace("\"gameRegistryId\":", "").Replace(@"mod/", "").Replace("\"", ""); }
                if (s.Contains("\"displayName\":")) { nam = s.Replace("\"displayName\":", "").Replace("\"", ""); }
                if (s.Contains("\"requiredVersion\":")) { ver = s.Replace("\"requiredVersion\":", "").Replace("\"", ""); }
            }

            //uid = ExtractFromBody(inf, "\"id\":\"", "\"},")[0];
            //mid = ExtractFromBody(inf, "\"gameRegistryId\":\"", "\",")[0];
            nam = ExtractFromBody(inf, "\"displayName\":\"", "\"")[0];
            //ver = ExtractFromBody(inf, "\"requiredVersion\":\"", "\",")[0];
            
			//MessageBox.Show(typ + "," + uid + "," + mid + "," + sid + "," + nam + "," + ver);
            WithPartsMadeInJapan o = new WithPartsMadeInJapan(typ, uid, mid, sid, nam, ver);
            return o;
        }
        private void ToThrowAwayThisMask()
        {
            //groupBox1.Location.X = groupBox1.Location.X + 1;
            int ListWidth = (this.Width - 20 - 200) / 2;
            int ListHeight = (this.Height - 40);

            listBoxACT.Width = ListWidth;
            listBoxACT.Height = ListHeight;
            listBoxALL.Location = new Point(10, 5);

            listBoxALL.Width = ListWidth;
            listBoxALL.Height = ListHeight;
            listBoxALL.Location = new Point(this.Width - 10 - ListWidth, 5);

            groupBox1.Location = new Point(10 + ListWidth, 5);
        }
        private void IAmTheModernMan()
        {
            listBoxACT.Items.Clear();
            listBoxALL.Items.Clear();

            for (int i = 0; i < mALL.Count; i++)
            {
				string sALL = "";
                if (mACT.Contains(mALL[i])) { sALL = "X"; }
                else { sALL = "_"; }
                sALL += listBoxALL.Items.Count.ToString().PadLeft(4, '_') + @":: " + mLST[mALL[i]].NowEveryoneCanSee();
                listBoxALL.Items.Add(sALL);

                if (mACT.Contains(mALL[i]))
                {
                    string sACT = "X";

                    sACT += listBoxACT.Items.Count.ToString().PadLeft(4, '_') + @":: " + mLST[mALL[i]].NowEveryoneCanSee();
                    listBoxACT.Items.Add(sACT);
                }
            }
        }
        private void ForgetWhatYouKnow(int i, int t)
        {
            string ent = mALL[i];
            mALL.RemoveAt(i);

            int targ = t;
            if (targ < 0) { targ = 0; }
            if (targ > mALL.Count) { targ = mALL.Count; }

            mALL.Insert(targ, ent);
            IAmTheModernMan();
        }
        private int WeAllNeedControl()
        {
            int res = -1;

                Form2 GIVEMECONTROL = new Form2();
                GIVEMECONTROL.StartPosition = FormStartPosition.Manual;
                GIVEMECONTROL.Left = Cursor.Position.X - (GIVEMECONTROL.Width/2);
                GIVEMECONTROL.Top = Cursor.Position.Y - (GIVEMECONTROL.Height/2);
                GIVEMECONTROL.numericUpDown1.Maximum = mALL.Count;

                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (GIVEMECONTROL.ShowDialog(this) == DialogResult.OK)
                {
                   // Read the contents of testDialog's TextBox.
                    res = (int)GIVEMECONTROL.numericUpDown1.Value;
                }
                else
                {
                    res = -1;
                }
                GIVEMECONTROL.Dispose();
        
            return res;
        }
        private void WelcomeToMyTwistedMind()
        {
            List<string> iNAM = new List<string>();
            List<string> oNAM = new List<string>();

            iNAM.AddRange(mNAM.Keys.ToList());

            for (int i = 0; i < iNAM.Count; i++)
            {
                Random r = new Random();
                int m = r.Next(0, iNAM.Count - 1);

                oNAM.Add(iNAM[m]);
                iNAM.RemoveAt(m);
            }

            mALL.Clear();
            for (int i = 0; i < oNAM.Count; i++)
            {
                mALL.Add(mNAM[oNAM[i]]);
            }
        }
        private void AlphabeticalSortingInMyModManagerItsMoreLikelyThanYouThink(bool backwards)
        {
            List<string> iNAM = new List<string>();
            List<string> oNAM = new List<string>();

            iNAM.AddRange(mNAM.Keys.ToList());
            iNAM.Sort();
            oNAM.AddRange(iNAM);

            mALL.Clear();
            if (backwards)
            {
                for (int i = oNAM.Count-1; i>=0; i--)
                {
                    mALL.Add(mNAM[oNAM[i]]);
                }
            }
            else
            {
                for (int i = 0; i < oNAM.Count; i++)
                {
                    mALL.Add(mNAM[oNAM[i]]);
                }
            }
        }

        //Events
        private void SoIfYouSeeMeActingStrangely(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    int targ = 0;
                    if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
                    {
                        targ = listBoxALL.SelectedIndex;
                        if (!mACT.Contains(mALL[listBoxALL.SelectedIndex]))
                        {
                            mACT.Add(mALL[listBoxALL.SelectedIndex]);
                        }
                        else
                        {
                            mACT.Remove(mALL[listBoxALL.SelectedIndex]);
                        }
                    }
                    IAmTheModernMan();
                    setSelectedTarget(targ);
                    break;
                case Keys.Up:
                    if (GasGasGASImGonnaStepOnTheGasTONIGHT)
                    {
                        int tU = 0;
                        if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
                        {
                            tU = listBoxALL.SelectedIndex - 1;
                            ForgetWhatYouKnow(listBoxALL.SelectedIndex, tU);
                        }
                        IAmTheModernMan();
                        setSelectedTarget(tU + 1);
                    }
                    break;
                case Keys.Down:
                    if (GasGasGASImGonnaStepOnTheGasTONIGHT)
                    {
                        int tD = 0;
                        if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
                        {
                            tD = listBoxALL.SelectedIndex + 1;
                            ForgetWhatYouKnow(listBoxALL.SelectedIndex, tD);
                        }
                        IAmTheModernMan();
                        setSelectedTarget(tD - 1);
                    }
                    break;
                default:
                    break;
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                GasGasGASImGonnaStepOnTheGasTONIGHT = true;
            }
        }
        private void DontBeSurprised(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                GasGasGASImGonnaStepOnTheGasTONIGHT = false;
            }
        }
		private void MataAuHimaDe_EV(object sender, EventArgs e)
		{
			MataAuHimaDe();
		}
		private void HimitsuWoShiriTai_EV(object sender, EventArgs e)
		{
			HimitsuWoShiriTai();
			MessageBox.Show("SAVED");
		}
        private void TheTimeHasComeAtLast(object sender, EventArgs e)
        {
            ToThrowAwayThisMask();
        }

        private void buttonUPPTOP_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = 0;
                ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
            }
            IAmTheModernMan();
            setSelectedTarget(targ);
        }
        private void buttonUPPNUM_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                int t = WeAllNeedControl();
                if (t == -1) { }
                else
                {
                    targ = listBoxALL.SelectedIndex - t;
                    ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
                    IAmTheModernMan();
                    setSelectedTarget(targ);
                }
            }
        }
        private void buttonUPPONE_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = listBoxALL.SelectedIndex - 1;
                ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
            }
            IAmTheModernMan();
            setSelectedTarget(targ);
        }
        private void buttonTOOSLW_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                int t = WeAllNeedControl();
                if (t == -1) { }
                else
                {
                    targ =  t;
                    ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
                    IAmTheModernMan();
                    setSelectedTarget(targ);
                }
            }
        }
        private void buttonDWNONE_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = listBoxALL.SelectedIndex + 1;
                ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
            }
            IAmTheModernMan();
            setSelectedTarget(targ);
        }
        private void buttonDWNNUM_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                int t = WeAllNeedControl();
                if (t == -1) { }
                else
                {
                    targ = listBoxALL.SelectedIndex + t;
                    ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
                    IAmTheModernMan();
                    setSelectedTarget(targ);
                }
            }
        }
        private void buttonDWNLOW_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = mALL.Count;
                ForgetWhatYouKnow(listBoxALL.SelectedIndex, targ);
            }
            IAmTheModernMan();
            setSelectedTarget(targ);
        }

        private void buttonYaACTALL_Click(object sender, EventArgs e)
        {
            mACT.Clear();
            mACT.AddRange(mALL);
            IAmTheModernMan();
        }
        private void buttonYaACTSEL_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = listBoxALL.SelectedIndex;
                if (!mACT.Contains(mALL[listBoxALL.SelectedIndex]))
                {
                    mACT.Add(mALL[listBoxALL.SelectedIndex]);
                }
            }
            IAmTheModernMan();
            setSelectedTarget(targ);
        }
        private void buttonDeACTSEL_Click(object sender, EventArgs e)
        {
            int targ = 0;
            if (listBoxALL.SelectedIndex >= 0 && listBoxALL.SelectedIndex < mALL.Count)
            {
                targ = listBoxALL.SelectedIndex;
                if (mACT.Contains(mALL[listBoxALL.SelectedIndex]))
                {
                    mACT.Remove(mALL[listBoxALL.SelectedIndex]);
                }
                IAmTheModernMan();
                setSelectedTarget(targ);
            }
            if (listBoxACT.SelectedIndex >= 0 && listBoxACT.SelectedIndex < mACT.Count)
            {
                targ = listBoxACT.SelectedIndex;
                if (mACT.Contains(mACT[listBoxACT.SelectedIndex]))
                {
                    mACT.Remove(mACT[listBoxACT.SelectedIndex]);
                }
                IAmTheModernMan();
                setSelectedTargetACT(targ);
            }
		}
        private void buttonDeACTALL_Click(object sender, EventArgs e)
        {
			mACT.Clear();
            IAmTheModernMan();
		}
		private void setSelectedTarget(int targ)
		{
			if (targ < 0) { targ = 0; }
            if (targ >= mALL.Count) { targ = mALL.Count - 1; }

			if (mALL.Count > 0) { listBoxALL.SelectedIndex = targ; }
		}
        private void setSelectedTargetACT(int targ)
        {
            if (targ < 0) { targ = 0; }
            if (targ >= mACT.Count) { targ = mACT.Count - 1; }

            if (mACT.Count > 0) { listBoxACT.SelectedIndex = targ; }
        }

        private void buttonSRTAUT_Click(object sender, EventArgs e)
        {
            int opt = 0;

            Form5 IllSortYouRightOut = new Form5();
            IllSortYouRightOut.StartPosition = FormStartPosition.Manual;
            IllSortYouRightOut.Left = Cursor.Position.X - (IllSortYouRightOut.Width / 2);
            IllSortYouRightOut.Top = Cursor.Position.Y - (IllSortYouRightOut.Height / 2);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (IllSortYouRightOut.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                opt = (int)IllSortYouRightOut.res;
            }
            else
            {
                opt = -1;
            }
            IllSortYouRightOut.Dispose();

            switch (opt)
            {
                case 0:
                    WelcomeToMyTwistedMind();
                    break;
                case 1:
                    AlphabeticalSortingInMyModManagerItsMoreLikelyThanYouThink(false);
                    break;
                case 2:
                    AlphabeticalSortingInMyModManagerItsMoreLikelyThanYouThink(true);
                    break;
                default:
                    break;
            }

            
            IAmTheModernMan();
        }

        private void listBoxALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int targ = listBoxALL.SelectedIndex;
            listBoxACT.SelectedIndex = -1;
            listBoxALL.SelectedIndex = targ;
        }
        private void listBoxACT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int targ = listBoxACT.SelectedIndex;
            listBoxALL.SelectedIndex = -1;
            listBoxACT.SelectedIndex = targ;
        }

        private void buttonIMPORD_Click(object sender, EventArgs e)
        {
            string iFIL = "";
            System.Windows.Forms.OpenFileDialog iORD;
            iORD = new System.Windows.Forms.OpenFileDialog();
            iORD.Filter = "KMOD* Files (*.kmod*)|*.kmod*";
            iORD.Title = "Load Mod Order";
            if (iORD.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            iFIL = iORD.FileName;

            Dictionary<string, string[]> imLST = new Dictionary<string, string[]>();
            List<string[]> imINV = new List<string[]>();
            List<string> imORD = new List<string>();
            List<string> amMOD = new List<string>();
            List<string> ulMOD = new List<string>();
            List<string> udMOD = new List<string>();

            using (StreamReader sr = new StreamReader(iFIL))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //MessageBox.Show(line);
                    string[] ms = line.Split('|');

                    if (ms.Length == 8) { if (!imLST.ContainsKey(ms[4])) { imLST.Add(ms[4], ms); } }
                    else { imINV.Add(ms); }
                }
            }

            //Sort Mods from Imported Load Order
            //for (int i = 0; i < keys.Count; i++)
            List<string> keys = new List<string>(imLST.Keys);
            ulMOD.AddRange(mMID.Keys);
            for (int i = 0; i < keys.Count; i++)
            {
                if (ulMOD.Contains(keys[i])) { ulMOD.Remove(keys[i]); }
                if (mMID.ContainsKey(keys[i]))
                {
                    imORD.Add(keys[i]);
                    if (imLST[keys[i]][0] == "True") { amMOD.Add(keys[i]); }
                }
                else
                {
                    udMOD.Add(keys[i]);
                }
            }

            //Add Listed Mods to the All/Act Lists
            mALL.Clear();
            mACT.Clear();
            for (int i = 0; i < imORD.Count; i++)
            {
                if (mMID.ContainsKey(imORD[i]))
                {
                    if (mLST.ContainsKey(mMID[imORD[i]]))
                    {
                        mALL.Add(mMID[imORD[i]]);
                        if (amMOD.Contains(imORD[i])) { mACT.Add(mMID[imORD[i]]); }
                    }
                }
            }
            //Add Unlisted Mods to the end of the All List
            for (int i = 0; i < ulMOD.Count; i++)
            {
                if (mMID.ContainsKey(ulMOD[i]))
                {
                    if (mLST.ContainsKey(mMID[ulMOD[i]]))
                    {
                        mALL.Add(mMID[ulMOD[i]]);
                    }
                }
            }

            //Display Dialogue showing Invalid Mod Entries
            if (imINV.Count > 0)
            {
                Form4 HeyWhereAllTheInvalidModsAt = new Form4();
                HeyWhereAllTheInvalidModsAt.clrTB();
                HeyWhereAllTheInvalidModsAt.setTitle("WARNING : The Following Mods were not correctly defined in the inported Mod Load Order.");
                for (int i = 0; i < imINV.Count; i++)
                {
                    string inv = "";
                    inv = imINV[i][0];
                    for (int j = 1; j < imINV[i].Length; j++) { inv += " | " + imINV[i][j]; }
                    HeyWhereAllTheInvalidModsAt.addTB(inv);
                }
                HeyWhereAllTheInvalidModsAt.Show();
            }
            //Display Dialogue showing Un-Downloaded Mods
            if (udMOD.Count > 0)
            {
                Form4 HeyWhereAllTheUndownloadedModsAt = new Form4();
                HeyWhereAllTheUndownloadedModsAt.clrTB();
                HeyWhereAllTheUndownloadedModsAt.setTitle("WARNING : The Following Mods were listed in the inported Mod Load Order but do not exist on your Machine");
                HeyWhereAllTheUndownloadedModsAt.addTB(@"Activated | Load Order Index | TYP | Mod UID | Mod File | Mod Name | Supported Version");
                HeyWhereAllTheUndownloadedModsAt.addTB(@"=====");
                for (int i = 0; i < udMOD.Count; i++)
                {
                    string s1 = "";
                    string s2 = "";

                    s1 = imLST[udMOD[i]][0] + @" | " + imLST[udMOD[i]][1] + @" | " + imLST[udMOD[i]][2] + @" | " + imLST[udMOD[i]][3] + @" | " + imLST[udMOD[i]][4] + @" | " + imLST[udMOD[i]][5] + @" | " + imLST[udMOD[i]][6];
                    s2 = @"           MOD Download URL = " + imLST[udMOD[i]][7];
                    HeyWhereAllTheUndownloadedModsAt.addTB(s1);
                    HeyWhereAllTheUndownloadedModsAt.addTB(s2);
                    //MessageBox.Show(udMOD[i]);
                    //WhereAllTheUndownloadedModsAt.addTB(imLST[udMOD[i]][2]);
                }
                HeyWhereAllTheUndownloadedModsAt.Show();
            }

            IAmTheModernMan();
        }
        private void buttonEXPORD_Click(object sender, EventArgs e)
        {
            string oFIL = "";
            System.Windows.Forms.SaveFileDialog eORD;
            eORD = new System.Windows.Forms.SaveFileDialog();
            eORD.Filter = "KMOD-Lite Files (*.kmodl)|*.kmodl|KMOD-Full Files (*.kmodf)|*.kmodf";
            eORD.Title = "Save Mod Order";
            if (eORD.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            oFIL = eORD.FileName;

            bool fullList = false;
            if (Path.GetExtension(oFIL).ToLower() == @".kmodf") { fullList = true; }

            IAmTheModernMan();
            using (StreamWriter sr = new StreamWriter(oFIL))
            {
                for (int i = 0; i < mALL.Count; i++)
                {
                    string[] oM = new string[2];
                    if (mACT.Contains(mALL[i]))
                    {
                        oM = mLST[mALL[i]].ImWearingAMask(true, i);
                        sr.WriteLine(oM[0] + @"|" + oM[1]);
                    }
                    else if (fullList)
                    {
                        oM = mLST[mALL[i]].ImWearingAMask(false, i);
                        sr.WriteLine(oM[0] + @"|" + oM[1]);
                    }
                }
            }
        }
    }
    public class WithPartsMadeInJapan
    {
        public string           TYP; //Mod Typ : L=Local S=Steam
        public string           UID; //Local ID -- ex : "eba4e308-f257-487f-b1f3-30641890813c"
        public string           MID; //Game Registry ID -- ex : "mod/ugc_1877398795.mod"
        public string           SID; //Steam ID (IF Applicable)
        public string           NAM;
        public string           VER;
        public List<string>     TAG;

        public WithPartsMadeInJapan(string typ, string uid, string mid, string sid, string nam, string ver)
        {
            TYP = typ;
            UID = uid;
            MID = mid;
            SID = sid;
            NAM = nam;
            VER = ver;

            TAG = new List<string>();
        }
        public void addTag(string t)
        {
            if (!TAG.Contains(t)) { TAG.Add(t); }
        }
        public string NowEveryoneCanSee()
        {
            string res = "";

            res = MID.PadLeft(20, ' ') + " : " + VER.PadLeft(10, ' ') + " :: " + NAM;

            return res;
        }
        public void MyTrueIdentity()
        {
            //Form3 KROY = new Form3();
            
            //That No One will Ever See
        }
        public string[] ImWearingAMask(bool act, int ord)
        {
            string[] o = new string[2] {"", ""};

            //s1 = Mod Overview
            o[0] = act + @"|" + ord + @"|" + TYP + @"|" + UID + @"|" + MID + @"|" + NAM + @"|" + VER;

            //s2 = Mod Address
            o[1] = "NA";
            switch (TYP)
            {
                case "S":   //Steam
                    o[1] = @"https://steamcommunity.com/sharedfiles/filedetails/?id=" + SID; 
                    break;
                case "P":   //Paradox Plaza
                    o[1] = "NA";    
                    break;
                default:    //NULL
                    o[1] = "NA";
                    break;
            }

            //Final String to be Saved to Exported Mod Load Order;
            //X/O | ORD | TYP | UID | MID | NAM | VER | URL

            return o;
        }
    }
}
