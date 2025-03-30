using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Business.Models;
using DevExpert.Marketplace.Data.Context;

namespace DevExpert.Marketplace.Data.Repositories;

public class SellerRepository(MarketplaceContext context) 
    : Repository<Seller>(context), ISellerRepository;