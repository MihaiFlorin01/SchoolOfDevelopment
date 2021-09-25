﻿using FluentValidation;
using SchoolOf.Common.Enums;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Mappers
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateOrderValidator(IUnitOfWork unitOfWork)
        {
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().Must(x => IsValidEmailAdress(x)).WithMessage("Invalid email address.");
            RuleFor(x => x.CartId).NotEmpty().MustAsync((x, cancellationToken) => IsValidCart(x)).WithMessage("Invalid cart id.");
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.PhoneNo).NotEmpty();
            _unitOfWork = unitOfWork;
        }

        private async Task<bool> IsValidCart(long cartId)
        {
            var cart = await _unitOfWork.GetRepository<Cart>().GetByIdAsync(cartId);

            return cart != null && cart.Status == CartStatus.Created && !cart.IsDeleted;
        }

        public bool IsValidEmailAdress(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
