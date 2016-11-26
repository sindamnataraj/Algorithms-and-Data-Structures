using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    class MeetingRoomProblems
    {
        public class Interval {
            public int StartTime;
            public int EndTime;
            public Interval(int start, int end)
            {
                StartTime = start;
                EndTime = end;
            }
        }

        public static void TestMeetingRoomsProblem()
        { 
            //no overlapping
            //1 overlap
            //2 overlap
        }



        public static int MeetingRoomsRequired(List<Interval> meetings)
        {
            if (meetings.Count == 0) return 0;


            int numOfActiveRooms = 1;
            int maxRoomsAtAnyPoint = 0;


            int i = 1;
            while (i < meetings.Count)
            {
                if (AreOverlappingIntervals(meetings[i - 1], meetings[i]))
                {
                    numOfActiveRooms++;
                }
                else
                {
                    if (numOfActiveRooms > maxRoomsAtAnyPoint)
                    {
                        maxRoomsAtAnyPoint = numOfActiveRooms;
                    }
                    numOfActiveRooms = 1;
                }
            }

            return maxRoomsAtAnyPoint;

                                

        }

        public static List<Interval> MergeOverLappingIntervals(List<Interval> intervals)
        {
            List<Interval> result = new List<Interval>();
            if (intervals.Count == 0) return result;

            MergeSortIntervals(ref intervals,0, intervals.Count - 1);

            result.Add(intervals[0]);
            
            for (int i = 1; i < intervals.Count; i++)
            {
                Interval prevInterval = result[result.Count - 1];
                Interval curInterval = intervals[i];
                if (AreOverlappingIntervals(prevInterval, curInterval))
                {
                    result[result.Count - 1] = MergeTwo_Overlapping_Intervals(prevInterval, curInterval);
                }
                else
                {
                    result.Add(curInterval);
                }
            }

            return result;
               
        }



        public static bool CanAttendAllMeetings(List<Interval> intervals)
        {
            if (intervals.Count == 0) return true;
            MergeSortIntervals(ref intervals, 0, intervals.Count - 1);

            for (int i = 1; i < intervals.Count; i++)
            {
                if (AreOverlappingIntervals(intervals[i - 1], intervals[i])) return false;
            }

            return true;
        }
        public static bool AreOverlappingIntervals(Interval interval1, Interval interval2)
        {
            if (interval2.StartTime < interval1.EndTime) return true;
            return false;
        }
        public static Interval MergeTwo_Overlapping_Intervals(Interval first, Interval second)
        {
            return new Interval(first.StartTime,second.EndTime);
        }


        public static void MergeSortIntervals(ref List<Interval> intervals, int p, int q)
        {
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                MergeSortIntervals(ref intervals, p, mid);
                MergeSortIntervals(ref intervals, mid + 1, q);
                MergeSortedIntervals(ref intervals, p, mid, q);
            }
        }
        public static void MergeSortedIntervals(ref List<Interval> intervals, int p, int mid, int q)
        {
            int len1 = mid - p+1;
            int len2 = q - p;

            List<Interval> left = new List<Interval>();
            List<Interval> right = new List<Interval>();
            int i = 0;

            for(i=0;i<len1;i++)
            {
                left.Add(intervals[p + i]);
            }

            for (i = 0; i < len2; i++)
            {
                right.Add(intervals[mid + 1 + i]);
            }


            int j = 0;
            i = 0;
            int k = p;
            while (i < len1 && j < len2)
            {
                if (left[i].StartTime <= right[j].StartTime)
                {
                    intervals[k] = left[i];
                    i++;
                }
                else
                {
                    intervals[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < len1)
            {
                    intervals[k] = left[i];
                    i++;
                k++;
            }

            while (j < len2)
            {
                intervals[k] = right[j];
                j++;
                k++;
            }
        }

    }
}
