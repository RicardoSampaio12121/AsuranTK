/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains an interface IUser that receives IPerson
 */

namespace BusinessObjects.User
{
    public interface IUser : IPerson
    {
        public string Apikey { get; set; }
        public string Password { get; set; }
    }
}