﻿using FluentValidation;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolOf.Validators
{
    public class CartProductValidator : AbstractValidator<CartProductDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartProductValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(x => x.CartId).MustAsync((cartId, cancellationToken) => CartIdIsValid(cartId));
            RuleFor(x => x.ProductId).GreaterThan(0).MustAsync(ProductIdIsValid).WithMessage("Invalid product id.");
        }

        private async Task<bool> ProductIdIsValid(long productId, CancellationToken cancellationToken)
        {
            var productRepo = _unitOfWork.GetRepository<Product>();

            var product = await productRepo.GetByIdAsync(productId);

            return product != null && !product.IsDeleted;
        }

        public async Task<bool> CartIdIsValid(long cartId)
        {
            if (cartId == 0)
            {
                return true;
            }

            var cartRepo = _unitOfWork.GetRepository<Cart>();

            var cart = await cartRepo.GetByIdAsync(cartId);

            return cart != null && !cart.IsDeleted && cart.Status == Common.Enums.CartStatus.Created;
        }

    }
}