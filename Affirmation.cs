namespace AffirmationAPI{
    public static class Affirmation{
        static string[] x= {
            "_", "hello", "friend"
            };

        

        public static string getAffirmationByIndex(int indx){
            return indx > x.Length -1 ? x[x.Length -1] : x[indx];
        }
    
    }
}