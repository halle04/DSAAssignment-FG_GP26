
using System;

namespace Environment.Tasks {
    public class BinarySearch {
        public int BiSearch(Employee[] inArray, DateTime x) {
            int low = 0, high = inArray.Length - 1;

            while(low <= high) {
                int median = low + (high - low) / 2;

                DateTime date = DateTime.Parse(inArray[median].LastEntranceInEngineRoom);

                if(date == x)
                    return median;

                if(date < x)
                    low = median + 1;
                else
                    high = median - 1;
            }

            return -1;
        }
    }
}
