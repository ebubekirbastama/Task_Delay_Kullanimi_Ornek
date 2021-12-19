        public async void Form1_Load(object sender, EventArgs e)
        {
            //await EBSverilistele();
            await EBSVerilisteleASYNnc();
        }
        
        
        
        public async Task EBSVerilisteleASYNnc()
        {
            await Task.Delay(500);
            verilistele();

        }
