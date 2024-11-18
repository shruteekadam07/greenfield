﻿using Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities;


namespace Services
{
    public class CartService : ICartService
    {
        Cart theCart = null;

        //Dependancy injection
        public CartService(Cart cart) {
            this.theCart = cart;    
        }    
        public bool AddToCart(Item item)
        {
            this.theCart.Items.Add(item);
            return false;
        }

        public bool Empty()
        {
            this.theCart.Items.Clear();
            return false;
        }

        public List<Item> GetAll()
        {
            return new List<Item>();
        }

        public bool RemoveFromCart(int id)
        {
            theCart.Items.RemoveAll((item)=>(item.ProductId==id));
            return false;
        }
    }
}