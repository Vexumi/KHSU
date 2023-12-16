using Parser.Model;
using System.Globalization;

namespace Parser
{
    public static class ExperimentLoader
    {
        private static string[] GetFileData(string filepath)
        {
            var rawData = File.ReadAllText(filepath);

            // NOTICE: files can be empty
            if (rawData == "") throw new Exception("Empty file");

            // FIX: replacing strings like "123-456" to "123 -456"
            rawData = System.Text.RegularExpressions.Regex.Replace(rawData, @"-+", " -");

            // FIX: replacing string like "123   456" to "123 456"
            rawData = System.Text.RegularExpressions.Regex.Replace(rawData, @"\s+", " ");

            return rawData.Trim().Split(' ');
        }

        public static dynamic GetExperiment(string filepath)
        {
            try
            {
                return ExperimentLoader.GetData(filepath);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private static Experiment GetData(string filepath)
        {
            var exp = new Experiment();

            var data = GetFileData(filepath);

            exp.Name = Path.GetFileName(filepath);
            exp.CountChannels = int.Parse(data[0]); // 0
            for (int i = 0; i < 4; i++)
            {
                exp.ChannelsNumber.Add(int.Parse(data[1 + i]));
            } // 1 2 3 4
            for (int i = 0; i < 5; i++)
            {
                exp.Coupling.Add(int.Parse(data[5 + i]));
            } // 5 6 7 8 9
            exp.AnlTrigMode = int.Parse(data[10]) == 1 ? true : false; // 10
            exp.AntTrigChannel = int.Parse(data[11]); // 11
            exp.LevelAnlTrig = double.Parse(data[12]); // 12
            exp.AnlTrigSlope = int.Parse(data[13]); // 13
            exp.ScanRate = double.Parse(data[14], CultureInfo.InvariantCulture); // 14 // watch
            exp.DigTrigMode = int.Parse(data[15]) == 1 ? true : false; // 15
            exp.DigTrigEdge = int.Parse(data[16]); // 16
            exp.CountFramesDev = int.Parse(data[17]); // 17
            exp.PreTrigScan = int.Parse(data[18]); // 18
            exp.PostTrigScan = int.Parse(data[19]); // 19
            exp.PostTrigDelaySus = double.Parse(data[20]); // 20
            exp.FrameToDraw = int.Parse(data[21]); // 21
            exp.CountGraph = int.Parse(data[22]); // 22
            int index = 23;
            for (int i = 0; i < 4; i++)
            {
                exp.Graph.Add(new List<int>());
                for (int j = 0; j < 4; j++, index++)
                {
                    exp.Graph[i].Add(int.Parse(data[index]));
                }
            } // 23 - 38


            for (int i = 39; i < exp.PosFramesEnd; i++) {
                exp.FramesToRecordDev.Add(int.Parse(data[i]));
            } // 39 - ?

            for (int i = exp.PosFramesEnd+1; i < exp.PosTimesEnd; i++)
            {
                exp.TimeBuff.Add(double.Parse(data[i].Replace(".", ",")));
            } // ? - ??

            index = exp.PosTimesEnd + 1;
            for (int i = 0; i < exp.CountFrames; i++)
            {
                exp.Data.Add(new List<double>());
                for (int j = 0; j < exp.CountReading; j++, index++)
                {
                    exp.Data[i].Add(double.Parse(data[index], CultureInfo.InvariantCulture)); // watch
                }
            } // ?? - end

            return exp;
        }
    }
}