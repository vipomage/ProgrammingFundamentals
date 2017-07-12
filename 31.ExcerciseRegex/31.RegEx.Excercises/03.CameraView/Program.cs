using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var numsPattern = @"\d+";
            var cameraPattern = @"\|<";

            var digitStr = Console.ReadLine();
            var cameraStr = Console.ReadLine();

            MatchCollection numsMatches = Regex.Matches(digitStr, numsPattern);
            var skipElement = int.Parse(numsMatches[0].Value);
            var takeElement = int.Parse(numsMatches[1].Value);

            MatchCollection cameraMatches = Regex.Matches(cameraStr, cameraPattern);
            //var cameraStrArr = cameraStr.ToCharArray().ToList();
            List<int> cameraIndexes = new List<int>();
            List<string> pictures = new List<string>();
            var tempCameraStr = cameraStr;
            var zeroIndex = 0;

            foreach ( Match camera in cameraMatches )
            {
                var index = tempCameraStr.IndexOf(camera.Value);
                cameraIndexes.Add(index + zeroIndex);
                zeroIndex += index + 2;
                tempCameraStr = tempCameraStr.Substring(index + 2);
            }

            for ( int i = 0; i < cameraIndexes.Count - 1; i++ )
            {
                var currentCamIndex = cameraIndexes[i];
                var currentCamPic = currentCamIndex + 2;
                var currentPic = string.Empty;
                var currentTakeElement = takeElement;
                var picIndex = 0;

                if ( currentCamPic + skipElement > cameraIndexes[i + 1] )
                {
                    continue;
                }

                if ( currentCamPic + skipElement + takeElement > cameraIndexes[i + 1] )
                {
                    currentTakeElement = cameraIndexes[i + 1] - currentCamPic - skipElement;
                }

                picIndex = currentCamPic + skipElement;
                currentPic = cameraStr.Substring(picIndex, currentTakeElement);
                pictures.Add(currentPic);
            }

            if ( cameraMatches.Count == 0 )
            {
                return;
            }

            var lastCamPic = cameraIndexes[cameraIndexes.Count - 1] + 2;
            if ( skipElement + takeElement > cameraStr.Length - lastCamPic )
            {
                takeElement = cameraStr.Length - lastCamPic - skipElement;
            }

            pictures.Add(cameraStr.Substring(lastCamPic + skipElement, takeElement));
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", pictures));
        }
    }
}