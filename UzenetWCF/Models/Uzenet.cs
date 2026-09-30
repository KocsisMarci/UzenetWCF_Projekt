using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace UzenetWCF.Models
{

    [DataContract]
    public class Uzenet
    {

        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Szoveg {  get; set; }

        [DataMember]
        public DateTime KuldesiIdo { get; set; }
        
        [DataMember]
        public string UzenetTipus { get; set; }
        
        [DataMember]
        public string Telefon { get; set; }
        
        [DataMember]
        public string Email { get; set; }

        public Uzenet(int id, string szoveg, DateTime kuldes, string uzenetipus, string telefon, string email) {
            this.Id = id;
            this.Szoveg= szoveg; 

            this.KuldesiIdo = kuldes;

            this.UzenetTipus = uzenetipus;
            this.Telefon= telefon;
            this.Email = email;
        }


        public override string ToString()
        {
            return $"Id: {Id}, szöveg: {Szoveg}, küldés ideje: {KuldesiIdo}, üzenet típusa: {UzenetTipus}, telefon: {Telefon} email: {Email}";
        }
    }
}