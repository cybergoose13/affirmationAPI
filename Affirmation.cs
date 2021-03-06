using System;
using System.Collections.Generic;

namespace AffirmationAPI{
    public static class Affirmation{

        private static List<string> affirmationList= new List<string>(){
            "I am successful in whatever I do",
            "I plan my work and work my plan",
            "I focus on what is truly essential",
            "I will make the most of new opportunities",
            "Good flows to me, good flows from me",
            "I feel wonderful and alive",
            "I feel the joy of abundance",
            "I speak with confidence and calm assurance",
            "The universe provides for my every want and need",
            "I am healthy and happy",
            "I have a lot of energy",
            "I radiate happiness",
            "I am successful in whatever I do",
            "Everything is getting better every day",
            "My mind is calm",
            "I am always on the path of success & victory",
            "I am peace with myself",
            "I find peace and joy in all aspects of my life",
            "I have value and I matter",
            "I am a success in all that I do",
            "I am happy",
            "I feel joy, love, and abundance",
            "I am one with my inner child",
            "I am amazing",
            "I can do anything",
            "I am prepared to succeed",
            "Positivity is a choice",
            "I am fabulous, funny, and giving",
            "I am outstanding",
            "I am unique and special and most importantly I am me",
            "I am financially free",
            "I am perfect exactly as I am",
            "I focus on what is truly essential",
            "I make positive healthy choices",
            "I am in control of my reactions",
            "I find all solutions within me",
            "All is well in my life",
            "I will make the most of new opportunities",
            "I organize my priorities with clarity",
            "I forgive myself",
            "I am forgiven",
            "I will always be there for myself",
            "I enjoy the variety of life",
            "I am my own guru",
            "I take good care of myself",
            "I am patient with myself",
            "I let go of my past",
            "I am evolving eternally",
            "I know I can always upgrade",
            "There is a gift for me in everything that I experience",
            "I follow my inner guidance",
            "I appreciate my physical body",
            "I treat my body well",
            "I take it easy",
            "I make room for fun and playfulness",
            "I appreciate intimacy",
            "I am very good at letting go",
            "I am grateful for my life",
            "I love being myself",
            "Time is on my side",
            "I surrender to love",
            "I invite bliss",
            "I learn from my past",
            "I am good at walking the talk",
            "I enjoy being taken good care of by the universe",
            "I create my reality on a continuous basis",
            "My body is healthy",
            "I am superior to negative thoughts and low actions",
            "I forgive those who have harmed me in my past and peacefully detach from them",
            "I possess the qualities needed to be extremely successful",
            "My business is growing, expanding, and thriving",
            "My ability to conquer my challenges is limitless",
            "My potential to succeed is infinite",
            "I am courageous and I stand up for myself",
            "My thoughts are filled with positivity and my life is plentiful with prosperity",
            "I am blessed with an incredible family and wonderful friends",
            "I am a powerhouse",
            "My future is an ideal projection of what I envision now",
            "I radiate beauty, charm, and grace",
            "I am conquering my illness",
            "I wake up today with strength in my heart and clarity in my mind",
            "My fears of tomorrow are simply melting away",
            "My life is just beginning",
            "The assertion that something exists or is true",
            "I always have everything I need to be happy",
            "I live a positive life and only attract the best in my life",
            "I am peacefully allowing my life to unfold",
            "Today, and every day, I choose to be happy",
            "I am fun energetic and people love me for it",
            "My life overflows with happiness and love",
            "Today is rich with opportunity and I open my heart to receive them",
            "I take the time to show my friends that I care about them",
            "I am thankful that I get to live another day",
            "I see the world with beauty and color",
            "I deserve whatever good comes my way today",
            "I believe in myself",
            "I radiate confidence, certainty and optimism",
            "I courageously open and move through every door of opportunity",
            "I am in charge of my life",
            "I have the power to love my dreams",
            "My mind has unlimited power",
            "I stand up for what I believe in",
            "I act with courage and confidence",
            "I love myself more everyday",
            "I am blessed with an incredible family and wonderful friends"
        };

        public static string getAffirmationByIndex(int index) {
            if(isEmpty()) throw new IndexOutOfRangeException();
            return index > affirmationList.Count -1 ? affirmationList[affirmationList.Count - 1] : affirmationList[index];
        }

        public static string getRandomAffirmation(){
            if(isEmpty()) throw new NullReferenceException();
            return affirmationList[ (int) new Random().Next(0, affirmationList.Count) ];
        }

        public static List<string> getAffirmationList(){
            return affirmationList;
        }

        public static int Length(){
            return affirmationList.Count;
        }

        public static void setAffirmationAt(int index, string affirmation){
            affirmationList[index] = affirmation;
        }

        public static List<string> getTextFileList(string path){
            if(!(System.IO.File.Exists(@path))) throw new NullReferenceException();
            List<string> textList= new List<string>();
            string[] lines= System.IO.File.ReadAllLines(@path);
            foreach (var line in lines){
                textList.Add(line);
            }
            return textList;
        }

        public static void getRandomTextFileAff(string path){}

        public static void getJsonFileList(string path){}

        public static void getRandomJsonFileAff(string path){}

        public static bool isEmpty(){
            return affirmationList.Count == 0 || affirmationList == null ? true : false;
        }
    
    }
}