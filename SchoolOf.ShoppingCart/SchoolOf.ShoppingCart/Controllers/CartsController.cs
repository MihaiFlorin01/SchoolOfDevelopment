using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolOf.Common.Exceptions;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using SchoolOf.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOf.ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<CartProductDto> _cartValidator;
        public CartsController(IUnitOfWork unitOfWork, IMapper mapper, IValidator<CartProductDto> cartValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cartValidator = cartValidator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CartProductDto), 200)]
        public async Task<IActionResult> AddProductToCart([FromBody] CartProductDto cartProduct)
        {
            var validationResult = await _cartValidator.ValidateAsync(cartProduct);
            if (!validationResult.IsValid)
            {
                throw new InternalValidationException(validationResult.Errors.Select(validationError => validationError.ErrorMessage).ToList());
            }

            var cartRepo = _unitOfWork.GetRepository<Cart>();
            var productRepo = _unitOfWork.GetRepository<Product>();

            Cart cart = null;

            cart = cartRepo.Find(x => x.Id == cartProduct.CartId, nameof(Cart.Products)).FirstOrDefault();

            if (cart == null)
            {
                var product = await productRepo.GetByIdAsync(cartProduct.ProductId);

                cart = new Cart
                {
                    Status = Common.Enums.CartStatus.Created,
                    Products = new List<Product> { product }
                };

                cartRepo.Add(cart);
            }
            else
            {
                var product = await productRepo.GetByIdAsync(cartProduct.ProductId);

                cart.Products.Add(product);
                cartRepo.Update(cart);
            }

            await _unitOfWork.SaveChangesAsync();

            return Ok(_mapper.Map<CartDto>(cart));
        }

        [HttpGet]
        [Route("{cartId}")]
        [ProducesResponseType(typeof(Cart), 200)]
        public async Task<Cart> GetCartAndCartProductsById(long cartId)
        {
            var cartRepo = _unitOfWork.GetRepository<Cart>();

            var cart = cartRepo.GetByIdAsync(cartId);

            return await cart;
        }

        [HttpDelete]
        [ProducesResponseType(typeof(CartProductDto), 200)]
        public async Task<bool> DeleteProductFromCart([FromBody] CartProductDto cartProduct)
        {
            var cartRepo = _unitOfWork.GetRepository<Cart>();
            var productRepo = _unitOfWork.GetRepository<Product>();

            var cart = await cartRepo.GetByIdAsync(cartProduct.CartId);

            var productId = new Product()
            {
                Id = cartProduct.ProductId 
            };

            var product = await productRepo.GetByIdAsync(productId.Id);

            var result = product.IsDeleted = true;

            await _unitOfWork.SaveChangesAsync();

            return result;
        }
    }
}
