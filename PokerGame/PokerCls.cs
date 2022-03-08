using System;
using System.Collections.Generic;

namespace PokerGame
{
    public class PokerCls
    {
        static List<string> mFullPlayCards = new List<string>();

        public static bool ThreeofKind(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // 123 equal
            // 234 equal
            // 345 equal
            if (mCards[0] == mCards[1] && mCards[0] == mCards[2] ||
                mCards[1] == mCards[2] && mCards[1] == mCards[3])
            {
                mResult = mCards[2] * 3;
                mHighCard = mCards[4];
                return true;
            }
            else
            if (mCards[2] == mCards[3] && mCards[2] == mCards[4])
            {
                mResult = mCards[2] * 3;
                mHighCard = mCards[1];
                return true;
            }
            return false;
        }

        public static bool OnePair(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // Equal Cards 1,2
            // Equel 2,3
            // Equal 3,4
            // Equal 4,5
            if (mCards[0] == mCards[1])
            {
                mResult = mCards[0] * 2;
                mHighCard = mCards[4];
                return true;
            }
            else
            if (mCards[1] == mCards[2])
            {
                mResult = mCards[1] * 2;
                mHighCard = mCards[4];
                return true;
            }
            else
            if (mCards[2] == mCards[3])
            {
                mResult = mCards[2] * 2;
                mHighCard = mCards[4];
                return true;
            }
            else
            if (mCards[3] == mCards[4])
            {
                mResult = mCards[3] * 2;
                mHighCard = mCards[2];
                return true;
            }

            mResult = 0;
            mHighCard = 0;
            return false;
        }
        public static bool TwoPairs(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // Equal Cards 1,2 and 3,4
            // Equal 1,2 and 4,5
            // Equal 2,3 and 4,5
            if (mCards[0] == mCards[1] && mCards[2] == mCards[3])
            {
                mResult = mCards[1] * 2 + mCards[3] * 2;
                mHighCard = mCards[4];
                return true;
            }
            else
            if (mCards[0] == mCards[1] && mCards[3] == mCards[4])
            {
                mResult = mCards[1] * 2 + mCards[3] * 2;
                mHighCard = mCards[2];
                return true;
            }
            else
            if (mCards[1] == mCards[2] && mCards[3] == mCards[4])
            {
                mResult = mCards[1] * 2 + mCards[3] * 2;
                mHighCard = mCards[0];
                return true;
            }
            mResult = 0;
            mHighCard = 0;
            return false;
        }

        public static bool FourOfKind(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // Positions 1234 equal
            // or Positions 2345 equal
            if (mCards[0] == mCards[1] && mCards[0] == mCards[2] && mCards[0] == mCards[3])
            {
                mResult = mCards[0] * 4;
                mHighCard = mCards[4];
                return true;
            }
            if (mCards[1] == mCards[2] && mCards[1] == mCards[3] && mCards[1] == mCards[4])
            {
                mResult = mCards[1] * 4;
                mHighCard = mCards[0];
                return true;
            }
            mResult = 0;
            mHighCard = 0;
            return false;
        }

        public static bool FullHouse(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // 12 equal and 345
            // 234 equal and 45 
            if (mCards[0] == mCards[1] && mCards[0] == mCards[2] && mCards[3] == mCards[4])
            {
                mResult = mCards[0] * 3 + mCards[3] * 2;
                mHighCard = mCards[4];
                return true;
            }
            if (mCards[0] == mCards[1] && mCards[2] == mCards[3] && mCards[2] == mCards[4])
            {
                mResult = mCards[0] * 2 + mCards[2] * 3;
                mHighCard = mCards[0];
                return true;
            }
            mResult = 0;
            mHighCard = 0;
            return false;
        }

        public static bool Straight(int[] mCards, ref int mResult, ref int mHighCard)
        {
            // cards in sequence
            //
            if (mCards[0] + 1 == mCards[1] &&
                mCards[1] + 1 == mCards[2] &&
                mCards[2] + 1 == mCards[3] &&
                mCards[3] + 1 == mCards[4])
            {
                mResult = 9999;
                mHighCard = mCards[4];
                return true;
            }
            // 5 consecutive values
            mResult = 0;
            mHighCard = 0;
            return false;
        }
        public static bool SeparateHands(string hands)
        {
            mFullPlayCards = new List<string>();
            var Hands = hands.Split('|');
            string mResult1 = "";
            int mTotal1 = 0;
            int mHigh1 = 0;
            int mPoker1 = 99;
            string mResult2 = "";
            int mTotal2 = 0;
            int mHigh2 = 0;
            int mPoker2 = 99;
            if (Hands.Length.Equals(2))
            {
                if (Evaluate(Hands[0].ToString(), ref mPoker1, ref mResult1, ref mTotal1, ref mHigh1) && Evaluate(Hands[1].ToString(), ref mPoker2, ref mResult2, ref mTotal2, ref mHigh2))
                {
                    Console.WriteLine("Hand 1 Results " + mResult1 + " [" + mTotal1.ToString() + "] [" + mHigh1.ToString() + "]");
                    Console.WriteLine("Hand 2 Results " + mResult2 + " [" + mTotal2.ToString() + "] [" + mHigh2.ToString() + "]");
                }
                else
                {
                    //Console.WriteLine("End Game");
                    return false;
                };
                if (mPoker1 < mPoker2)
                {
                    Console.WriteLine("Hand 1 wins!");
                }
                else
                    if (mPoker2 < mPoker1)
                {
                    Console.WriteLine("Hand 2 Wins!");
                }
                else
                if (mPoker1 == mPoker2)
                {
                    if (mTotal1 > mTotal2)
                    {
                        Console.WriteLine("Wow Same Poker hand but Player 1 wins, with better cards");
                    }
                    else if (mTotal2 < mTotal1)
                    {
                        Console.WriteLine("Wow Same Poker hand but Player 1 wins, with better cards");
                    }
                    else
                        if (mHigh1 > mHigh2)
                    {
                        Console.WriteLine("Wow Same Poker hand, but Player 1 wins, with better cards");
                    }
                    else
                        if (mHigh2 > mHigh1)
                    {
                        Console.WriteLine("Wow Same Poker hand, but Player 2 wins, with better cards");
                    }
                    else
                        Console.WriteLine("DRAW, No one wins, please try again");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Error: Hands Count [" + Hands.Length.ToString() + "]");
                Console.WriteLine("Please send 2 HandsHands separated by | Cards separated by , ");
                Console.WriteLine("");
                Console.WriteLine(@"Sample: PokerGame ""2D, 2S, 2H, 2C, 3S | AD, 9D, KD, 7D, 6D""");
                Console.WriteLine("Each card has Weight+Family");
                Console.WriteLine("Weight =  2, 3, 4, 5, 6, 7, 8, 9, 10, J Q K A for Jack, Queen, King, Ace");
                Console.WriteLine("Family = H D C S  for Harts, Diamonds, Clubes, Spades");
                return false;
            };
        }
  
        // Weight = 2, 3, 4, 5, 6, 7, 8, 9, 10, 11= J Jack, 12= Q Queen, 13= K King, A= 14 Ace
        // Family = H D C S   Harts Diamonds Clubes Spades
        public static bool ValidateCards(ref string[] cards)
        {
            List<string> SortList = new List<string>();

            string mFamily;
            string mWeight;
            string mCard;
            int mPosFound;
            // Check if Cards are valid Weight+Family so length 2 or 3 chars
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    mCard = cards[i].ToString().Trim();
                    if (mCard.Length > 3 || mCard.Length < 2)
                    {
                        Console.WriteLine("Invalid Card [" + mCard + "]");
                        return false;
                    }
                    // Separate Weight and Family
                    mFamily = mCard.Substring(mCard.Length - 1, 1);
                    switch (mFamily)
                    {
                        case "H":
                            {
                                //Console.WriteLine("Harts");
                                mFamily = "H";
                                break;
                            }
                        case "D":
                            {
                                //Console.WriteLine("Diamonds");
                                mFamily = "D";
                                break;
                            }
                        case "C":
                            {
                                //Console.WriteLine("Clubes");
                                mFamily = "C";
                                break;
                            }
                        case "S":
                            {
                                //Console.WriteLine("Spades");
                                mFamily = "S";
                                break;
                            }
                        default:
                            {
                                mFamily = "";
                                Console.WriteLine("No Valid Family in Card [" + mCard + "]");
                                break;
                            }
                    }
                    // Error on Family
                    if (mFamily == "") return false;
                    // Asign value to Weight parts 11= J Jack, 12= Q Queen, 13= K King, A= 14 Ace
                    mWeight = mCard.Substring(0, mCard.Length - 1).PadLeft(2, '0');
                    switch (mWeight)
                    {
                        case "02": case "03": case "04": case "05":
                        case "06": case "07": case "08": case "09": case "10":
                            break;
                        case "0J":
                            {
                                mWeight = "11";
                                break;
                            }
                        case "0Q":
                            {
                                mWeight = "12";
                                break;
                            }
                        case "0K":
                            {
                                mWeight = "13";
                                break;
                            }
                        case "0A":
                            {
                                mWeight = "14";
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Error in weight card ["+ mWeight + "]");
                                return false;
                            }
                    }
                    // Add to list to do the sort on Weight and Family
                    // Also to check for duplicate cards

                    mPosFound = mFullPlayCards.IndexOf(mWeight + "|" + mFamily); // + "|" + i.ToString());

                    if (mPosFound == -1)
                    {
                        SortList.Add(mWeight + "|" + mFamily); // + "|" + i.ToString());
                        mFullPlayCards.Add(mWeight + "|" + mFamily); // + "|" + i.ToString());
                    }
                    else
                    {
                        // Duplicated Value
                        Console.WriteLine("Duplicated Card [" + mCard + "]");
                        return false;
                    };
                }
                SortList.Sort();
                for (int i = 0; i < 5; i++)
                {
                    //Console.WriteLine(SortList[i] + " ["+ i + "]");
                    cards[i] = SortList[i];
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Verify 5 cards separated by and evaluate poker total value and highest value
        static private bool Evaluate(string hand, ref int mPoker, ref String mResult, ref int mTotal, ref int mHigh)
        {
            string[] cards = hand.Trim().Split(',');
            string[] mParts;
            if (cards.Length != 5)
            {
                Console.WriteLine("Cards received " + cards.Length.ToString());
                for (int i = 0; i < cards.Length; i++)
                {
                    Console.WriteLine("[" + cards[i].Trim() + "]");
                }
                mResult = "Error: Missing cards [" + (5 - cards.Length).ToString() + "]";
                return false;
            };
            if (ValidateCards(ref cards))
            {
                int[] mmCards = new int[5];
                char[] mmSuit = new char[5];

                int mHartSum = 0;
                int mDiamSum = 0;
                int mClubSum = 0;
                int mSpadSum = 0;

                // Console.WriteLine("OK 5 Sorted Cards");
                for (int i = 0; i < 5; i++)
                {
                    // Console.WriteLine(cards[i] + " [" + i + "]");
                    mParts = cards[i].Split('|');
                    mmCards[i] = Convert.ToInt32(mParts[0].ToString());
                    mmSuit[i] = mParts[1][0];
                    switch (mmSuit[i])
                    {
                        case 'H':
                            {
                                mHartSum++;
                                break;
                            }
                        case 'D':
                            {
                                mDiamSum++;
                                break;
                            }
                        case 'C':
                            {
                                mClubSum++;
                                break;
                            }
                        case 'S':
                            {
                                mSpadSum++;
                                break;
                            }
                    }
                }
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine(mmCards[i] + " [" + i + "] " + mmSuit[i]);
                //}
                // Console.WriteLine("Sp {0}, Ha {1}, Di {2}, Cl {3} ", mSpadSum, mHartSum, mDiamSum, mClubSum);

                mTotal = 0;
                mHigh = 0;
                //mPoker = 99;
                if ((Straight(mmCards, ref mTotal, ref mHigh)) && (mClubSum == 5 || mDiamSum == 5 || mHartSum == 5 || mSpadSum == 5))
                {
                    mPoker = 2;
                    mResult = "Straight Flush";
                    return true;
                }
                else
                if (FourOfKind(mmCards, ref mTotal, ref mHigh))
                {
                    mPoker = 3;
                    mResult = "Four of a Kind";
                    return true;
                }
                else if (FullHouse(mmCards, ref mTotal, ref mHigh))
                {
                    mPoker = 4;
                    mResult = "Full House";
                    return true;
                }
                else if (mClubSum == 5 || mDiamSum == 5 || mHartSum == 5 || mSpadSum == 5)
                {
                    mPoker = 5;
                    mHigh = mmCards[4];
                    mResult = "Flush";
                    return true;
                }
                else if (Straight(mmCards, ref mTotal, ref mHigh))
                {
                        mPoker = 6;
                        mResult = "Straight";
                        return true;
                }
                else if (ThreeofKind(mmCards, ref mTotal, ref mHigh))
                {
                    mPoker = 7;
                    mResult = "Three of a Kind";
                    return true;
                }
                else if (TwoPairs(mmCards, ref mTotal, ref mHigh))
                {
                    mPoker = 8;
                    mResult = "Two Pairs";
                    return true;
                }
                else if (OnePair(mmCards, ref mTotal, ref mHigh))
                {
                    mPoker = 9;
                    mResult = "One Pair";
                    return true;
                };
                // Nothing Found
                mPoker = 10;
                mResult = "Nada";
                mTotal = 0;
                mHigh = mmCards[4];
                return true;
            }
            else
            {
                Console.WriteLine("Not Valid Cards");
                return false;
            };
        }
      static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("parms " + args[i]);
                };
                if (args[0] == "-f" && args.Length == 2)
                {
                    try
                    {
                        fProcessFile(args[1]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }  
                }
                else
                {
                    Console.WriteLine("Please send 2 HandsHands separated by | Cards separated by , ");
                    Console.WriteLine("");
                    Console.WriteLine(@"Sample: PokerGame ""2D, 2S, 2H, 2C, 3S | AD, 9D, KD, 7D, 6D""");
                    Console.WriteLine("Each card has Weight+Family");
                    Console.WriteLine("Weight =  2, 3, 4, 5, 6, 7, 8, 9, 10, J Q K A for Jack, Queen, King, Ace");
                    Console.WriteLine("Family = H D C S  for Harts, Diamonds, Clubes, Spades");
                };
            }
            else
            {
                Console.WriteLine("Poker Game! Params ["  + args[0].ToString() +"]");
                SeparateHands(args[0].ToString());
            }
        }

        private static bool fProcessFile(string mFile)
        {
            string mLine;
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(mFile))
                {
                    while ((mLine = sr.ReadLine()) != null)      // Read Next Record to Process
                    {
                        if (mLine != "")
                        {
                            Console.WriteLine("Hands " + mLine);
                            SeparateHands(mLine);
                            Console.WriteLine("---------------");
                        }
                    }
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Error trying to open file "+mFile);
                return false;
            }
        }
    }
}
