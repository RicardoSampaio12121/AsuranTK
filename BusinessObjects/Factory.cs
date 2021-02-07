/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class to apply the dependency inversion principle
 *         this way, when initializing a new object this class is called instead
 */

using BusinessObjects.User;
using MySql.Data.MySqlClient;

namespace BusinessObjects
{
    public static class Factory
    {
        //Initializes an User object
        public static IUser CreateUser()
        {
            return new User.User();
        }
    }
    
}