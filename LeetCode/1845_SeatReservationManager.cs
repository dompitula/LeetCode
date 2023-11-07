//
// Solution to LeetCode problem #1845 - Seat Reservation Manager
//

namespace LeetCode
{
    /// <summary>
    /// Responsible for running the code.
    /// </summary>
    public class SeatManager
    {

        private int last;
        private SortedSet<int> seats;

        public SeatManager(int n)
        {
            last = 0;
            seats = new SortedSet<int>();
        }

        public int Reserve()
        {
            if (!seats.Any())
            {
                return ++last;
            }
            else
            {
                int lowestSeat = seats.Min;
                seats.Remove(lowestSeat);
                return lowestSeat;
            }
        }

        public void Unreserve(int seatNumber)
        {
            if (seatNumber == last)
            {
                --last;
            }
            else
            {
                seats.Add(seatNumber);
            }
        }
    }
}

/// Paste in Main method to run.
/*
    SeatManager seatManager = new SeatManager(5);
    Console.WriteLine(seatManager.Reserve());  // 1
    Console.WriteLine(seatManager.Reserve());  // 2
    seatManager.Unreserve(2);
    Console.WriteLine(seatManager.Reserve());  // 2
    Console.WriteLine(seatManager.Reserve());  // 3
    Console.WriteLine(seatManager.Reserve());  // 4
    Console.WriteLine(seatManager.Reserve());  // 5
    seatManager.Unreserve(5);
*/