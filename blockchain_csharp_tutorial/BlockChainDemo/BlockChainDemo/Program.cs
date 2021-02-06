using Newtonsoft.Json;
using System;

namespace BlockchainDemo {
    class Program {
        static void Main(string[] args) {
            //Create blockchain
            Blockchain rourkesCoin = new Blockchain();
            rourkesCoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
            rourkesCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Bob,receiver:Billy,amount:10}"));
            rourkesCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Dylon,receiver:Kael,amount:5}"));

            //Output blockchain
            Console.WriteLine(JsonConvert.SerializeObject(rourkesCoin, Formatting.Indented));

            //Validate chain
            Console.WriteLine($"Is Chain Valid: {rourkesCoin.IsValid()}");


            //Tamper with chain
            Console.WriteLine($"Update amount to 1000");
            rourkesCoin.Chain[1].Data = "{sender:Henry,receiver:MaHesh,amount:1000}";
            //Output tampered chain
            //Console.WriteLine(JsonConvert.SerializeObject(rourkesCoin, Formatting.Indented));

            //Validate bad chain
            Console.WriteLine($"Is Chain Valid: {rourkesCoin.IsValid()}");
        }
    }
}
