bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{

string answer;
string difEnter;
do
{
Console.Write("Welcome to restaurant picker. Enter ('random', 'american', 'mexican', or 'italian') to start: ");
difEnter = Console.ReadLine().ToLower();

if(difEnter != "random" && difEnter != "american" && difEnter != "mexican" && difEnter != "italian")   
{
    Console.WriteLine("Please enter valid data.");
}

}while(difEnter != "random" && difEnter != "american" && difEnter != "mexican" && difEnter != "italian");


        if(difEnter == "random")
        {
            var randomGenerator = new Random();
            int RandomRestaurantGen = randomGenerator.Next(0,30);
            switch(RandomRestaurantGen)
            {
                case 0 :
                Console.WriteLine("SALT - New American Table");
                break;

                case 1 :
                Console.WriteLine("The American Reserve");
                break;

                case 2 :
                Console.WriteLine("The Griffin American Grill");
                break;

                case 3 :
                Console.WriteLine("American Yard House");
                break;

                case 4 :
                Console.WriteLine("Cured American");
                break;

                case 5 :
                Console.WriteLine("Bodega American Tavern");
                break;

                case 6 :
                Console.WriteLine("Logans Roadhouse");
                break;

                case 7 :
                Console.WriteLine("The Russell");
                break;

                case 8 :
                Console.WriteLine("Brave New Tavern");
                break;

                case 9 :
                Console.WriteLine("LongHorn Steakhouse");
                break;

                case 10 :
                Console.WriteLine("Indio Azteca");
                break;

                case 11 :
                Console.WriteLine("La Embajada");
                break;

                case 12 :
                Console.WriteLine("Gallo 71");
                break;

                case 13 :
                Console.WriteLine("Los Hidalgos");
                break;

                case 14 :
                Console.WriteLine("La Reynita");
                break;

                case 15 :
                Console.WriteLine("San Carlos");
                break;

                case 16 :
                Console.WriteLine("La Mejico");
                break;

                case 17 :
                Console.WriteLine("Papalote Grill");
                break;

                case 18 :
                Console.WriteLine("Taco Palenque");
                break;

                case 19 :
                Console.WriteLine("CHEZ Cocina tradicional");
                break;

                case 20 :
                Console.WriteLine("Bottega");
                break;

                case 21 :
                Console.WriteLine("Caruso's Grocery");
                break;

                case 22 :
                Console.WriteLine("City House");
                break;

                case 23 :
                Console.WriteLine("Cotogna");
                break;

                case 24 :
                Console.WriteLine("Crust");
                break;

                case 25 :
                Console.WriteLine("Da Marco");
                break;

                case 26 :
                Console.WriteLine("Elina's");
                break;

                case 27 :
                Console.WriteLine("L.A. Felix");
                break;

                case 28 :
                Console.WriteLine("Haymaker");
                break;

                case 29 :
                Console.WriteLine("Giacomo's");
                break;
            // Console.WriteLine(answer);
            }
            }
            else if(difEnter == "american")
            {
            var randomGenerator = new Random();
            int RandomRestaurantGen = randomGenerator.Next(0,10);
            switch(RandomRestaurantGen)
            {
                case 0 :
                Console.WriteLine("SALT - New American Table");
                break;

                case 1 :
                Console.WriteLine("The American Reserve");
                break;

                case 2 :
                Console.WriteLine("The Griffin American Grill");
                break;

                case 3 :
                Console.WriteLine("American Yard House");
                break;

                case 4 :
                Console.WriteLine("Cured American");
                break;

                case 5 :
                Console.WriteLine("Bodega American Tavern");
                break;

                case 6 :
                Console.WriteLine("Logans Roadhouse");
                break;

                case 7 :
                Console.WriteLine("The Russell");
                break;

                case 8 :
                Console.WriteLine("Brave New Tavern");
                break;

                case 9 :
                Console.WriteLine("LongHorn Steakhouse");
                break;
            }
            

        }

        else if(difEnter == "mexican")
        {
            var randomGenerator = new Random();
            int RandomRestaurantGen = randomGenerator.Next(10,20);
            switch(RandomRestaurantGen)
            {
                case 10 :
                Console.WriteLine("Indio Azteca");
                break;

                case 11 :
                Console.WriteLine("La Embajada");
                break;

                case 12 :
                Console.WriteLine("Gallo 71");
                break;

                case 13 :
                Console.WriteLine("Los Hidalgos");
                break;

                case 14 :
                Console.WriteLine("La Reynita");
                break;

                case 15 :
                Console.WriteLine("San Carlos");
                break;

                case 16 :
                Console.WriteLine("La Mejico");
                break;

                case 17 :
                Console.WriteLine("Papalote Grill");
                break;

                case 18 :
                Console.WriteLine("Taco Palenque");
                break;

                case 19 :
                Console.WriteLine("CHEZ Cocina tradicional");
                break;
            }
        }

         else if(difEnter == "italian")
        {
            var randomGenerator = new Random();
            int RandomRestaurantGen = randomGenerator.Next(21,30);
            switch(RandomRestaurantGen)
            {
               
                case 21 :
                Console.WriteLine("Caruso's Grocery");
                break;

                case 22 :
                Console.WriteLine("City House");
                break;

                case 23 :
                Console.WriteLine("Cotogna");
                break;

                case 24 :
                Console.WriteLine("Crust");
                break;

                case 25 :
                Console.WriteLine("Da Marco");
                break;

                case 26 :
                Console.WriteLine("Elina's");
                break;

                case 27 :
                Console.WriteLine("L.A. Felix");
                break;

                case 28 :
                Console.WriteLine("Haymaker");
                break;

                case 29 :
                Console.WriteLine("Giacomo's");
                break;
            // Console.WriteLine(answer);
            }
            }
    validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}




        
    // }
    // public void RandomAmerican()
    // {
        
        
    //     if(myRandom == true)
    //     {
    //         System.Random randomGenerator = new System.Random();
    //         int RandomRestaurantGen = randomGenerator.Next(0,10);
    //         switch(RandomRestaurantGen)
    //         {
    //             case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9:
    //             RandomCategoryText.text = "American";
    //             myBG.sprite = BGAme;
    //             break;

    //         }

    //         switch(RandomRestaurantGen)
    //         {
    //             case 0 :
    //             RandomRestaurantText.text = "SALT - New American Table";
    //             break;

    //             case 1 :
    //             RandomRestaurantText.text = "The American Reserve";
    //             break;

    //             case 2 :
    //             RandomRestaurantText.text = "The Griffin American Grill";
    //             break;

    //             case 3 :
    //             RandomRestaurantText.text = "American Yard House";
    //             break;

    //             case 4 :
    //             RandomRestaurantText.text = "Cured American";
    //             break;

    //             case 5 :
    //             RandomRestaurantText.text = "Bodega American Tavern";
    //             break;

    //             case 6 :
    //             RandomRestaurantText.text = "Logans Roadhouse";
    //             break;

    //             case 7 :
    //             RandomRestaurantText.text = "The Russell";
    //             break;

    //             case 8 :
    //             RandomRestaurantText.text = "Brave New Tavern";
    //             break;

    //             case 9 :
    //             RandomRestaurantText.text = "LongHorn Steakhouse";
    //             break;
    //         }

    //     }
    // }
    // public void RandomMexican()
    // {
        
        
    //     if(myRandom == true)
    //     {
    //         System.Random randomGenerator = new System.Random();
    //         int RandomRestaurantGen = randomGenerator.Next(10,20);
    //         switch(RandomRestaurantGen)
    //         {

    //             case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17: case 18: case 19:
    //             RandomCategoryText.text = "Mexican";
    //             myBG.sprite = BGMex;
    //             break;


    //         }

    //         switch(RandomRestaurantGen)
    //         {
                
    //             case 10 :
    //             RandomRestaurantText.text = "Indio Azteca";
    //             break;

    //             case 11 :
    //             RandomRestaurantText.text = "La Embajada";
    //             break;

    //             case 12 :
    //             RandomRestaurantText.text = "Gallo 71";
    //             break;

    //             case 13 :
    //             RandomRestaurantText.text = "Los Hidalgos";
    //             break;

    //             case 14 :
    //             RandomRestaurantText.text = "La Reynita";
    //             break;

    //             case 15 :
    //             RandomRestaurantText.text = "San Carlos";
    //             break;

    //             case 16 :
    //             RandomRestaurantText.text = "La Mejico";
    //             break;

    //             case 17 :
    //             RandomRestaurantText.text = "Papalote Grill";
    //             break;

    //             case 18 :
    //             RandomRestaurantText.text = "Taco Palenque";
    //             break;

    //             case 19 :
    //             RandomRestaurantText.text = "CHEZ Cocina tradicional";
    //             break;

    //         }

    //     }
    // }
    // public void RandomItalian()
    // {
        
        
    //     if(myRandom == true)
    //     {
    //         System.Random randomGenerator = new System.Random();
    //         int RandomRestaurantGen = randomGenerator.Next(20,30);
    //         switch(RandomRestaurantGen)
    //         {

    //             case 20: case 21: case 22: case 23: case 24: case 25: case 26: case 27: case 28: case 29:
    //             RandomCategoryText.text = "Italian";
    //             myBG.sprite = BGIta;
    //             break;


    //         }

    //         switch(RandomRestaurantGen)
    //         {
    //             case 20 :
    //             RandomRestaurantText.text = "Bottega";
    //             break;

    //             case 21 :
    //             RandomRestaurantText.text = "Caruso's Grocery";
    //             break;

    //             case 22 :
    //             RandomRestaurantText.text = "City House";
    //             break;

    //             case 23 :
    //             RandomRestaurantText.text = "Cotogna";
    //             break;

    //             case 24 :
    //             RandomRestaurantText.text = "Crust";
    //             break;

    //             case 25 :
    //             RandomRestaurantText.text = "Da Marco";
    //             break;

    //             case 26 :
    //             RandomRestaurantText.text = "Elina's";
    //             break;

    //             case 27 :
    //             RandomRestaurantText.text = "L.A. Felix";
    //             break;

    //             case 28 :
    //             RandomRestaurantText.text = "Haymaker";
    //             break;

    //             case 29 :
    //             RandomRestaurantText.text = "Giacomo's";
    //             break;


    //         }

    //     }
    // }
    
