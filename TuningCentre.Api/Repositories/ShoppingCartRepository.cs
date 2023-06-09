﻿using TuningCentre.Api.Entities;
using TuningCentre.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using TuningCentre.Api.Data;
using TuningCentre.Api.Repositories.Contracts;

namespace TuningCentre.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly TuningCentreDbContext TuningCentreDbContext;

        public ShoppingCartRepository(TuningCentreDbContext TuningCentreDbContext)
        {
            this.TuningCentreDbContext = TuningCentreDbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.TuningCentreDbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                     c.ProductId == productId);

        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this.TuningCentreDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.TuningCentreDbContext.CartItems.AddAsync(item);
                    await this.TuningCentreDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;

        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.TuningCentreDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                this.TuningCentreDbContext.CartItems.Remove(item);
                await this.TuningCentreDbContext.SaveChangesAsync();
            }

            return item;

        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.TuningCentreDbContext.Carts
                          join cartItem in this.TuningCentreDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.TuningCentreDbContext.Carts
                          join cartItem in this.TuningCentreDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.TuningCentreDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.TuningCentreDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}
