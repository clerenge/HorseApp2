﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HorseApp2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HorseDatabaseEntities : DbContext
    {
        public HorseDatabaseEntities()
            : base("name=HorseDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblActiveListingPhoto> tblActiveListingPhotos { get; set; }
        public virtual DbSet<tblActiveListing> tblActiveListings { get; set; }
        public virtual DbSet<tblName> tblNames { get; set; }
        public virtual DbSet<tblActiveListingPhotosData> tblActiveListingPhotosDatas { get; set; }
        public virtual DbSet<tblActiveListingsData> tblActiveListingsDatas { get; set; }
        public virtual DbSet<tblSire> tblSires { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual int usp_DeleteActiveListing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteActiveListing");
        }
    
        public virtual int usp_DeleteSire(Nullable<long> sireServerId, string name)
        {
            var sireServerIdParameter = sireServerId.HasValue ?
                new ObjectParameter("SireServerId", sireServerId) :
                new ObjectParameter("SireServerId", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteSire", sireServerIdParameter, nameParameter);
        }
    
        public virtual int usp_InsertActiveListing(string activeListingId, Nullable<int> age, string color, string dam, string sire, string damSire, string description, string firebaseId, string gender, string horseName, Nullable<bool> inFoal, Nullable<decimal> lte, Nullable<System.DateTime> originalDateListed, Nullable<decimal> price, string purchaseListingType, string ranchPhoto, string sellerId, string horseType, Nullable<bool> isSold, string inFoalTo, Nullable<bool> isRegistered, Nullable<bool> callForPrice, Nullable<double> height)
        {
            var activeListingIdParameter = activeListingId != null ?
                new ObjectParameter("ActiveListingId", activeListingId) :
                new ObjectParameter("ActiveListingId", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var damParameter = dam != null ?
                new ObjectParameter("Dam", dam) :
                new ObjectParameter("Dam", typeof(string));
    
            var sireParameter = sire != null ?
                new ObjectParameter("Sire", sire) :
                new ObjectParameter("Sire", typeof(string));
    
            var damSireParameter = damSire != null ?
                new ObjectParameter("DamSire", damSire) :
                new ObjectParameter("DamSire", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var firebaseIdParameter = firebaseId != null ?
                new ObjectParameter("FirebaseId", firebaseId) :
                new ObjectParameter("FirebaseId", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var horseNameParameter = horseName != null ?
                new ObjectParameter("HorseName", horseName) :
                new ObjectParameter("HorseName", typeof(string));
    
            var inFoalParameter = inFoal.HasValue ?
                new ObjectParameter("InFoal", inFoal) :
                new ObjectParameter("InFoal", typeof(bool));
    
            var lteParameter = lte.HasValue ?
                new ObjectParameter("Lte", lte) :
                new ObjectParameter("Lte", typeof(decimal));
    
            var originalDateListedParameter = originalDateListed.HasValue ?
                new ObjectParameter("OriginalDateListed", originalDateListed) :
                new ObjectParameter("OriginalDateListed", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var purchaseListingTypeParameter = purchaseListingType != null ?
                new ObjectParameter("PurchaseListingType", purchaseListingType) :
                new ObjectParameter("PurchaseListingType", typeof(string));
    
            var ranchPhotoParameter = ranchPhoto != null ?
                new ObjectParameter("RanchPhoto", ranchPhoto) :
                new ObjectParameter("RanchPhoto", typeof(string));
    
            var sellerIdParameter = sellerId != null ?
                new ObjectParameter("SellerId", sellerId) :
                new ObjectParameter("SellerId", typeof(string));
    
            var horseTypeParameter = horseType != null ?
                new ObjectParameter("HorseType", horseType) :
                new ObjectParameter("HorseType", typeof(string));
    
            var isSoldParameter = isSold.HasValue ?
                new ObjectParameter("IsSold", isSold) :
                new ObjectParameter("IsSold", typeof(bool));
    
            var inFoalToParameter = inFoalTo != null ?
                new ObjectParameter("InFoalTo", inFoalTo) :
                new ObjectParameter("InFoalTo", typeof(string));
    
            var isRegisteredParameter = isRegistered.HasValue ?
                new ObjectParameter("IsRegistered", isRegistered) :
                new ObjectParameter("IsRegistered", typeof(bool));
    
            var callForPriceParameter = callForPrice.HasValue ?
                new ObjectParameter("CallForPrice", callForPrice) :
                new ObjectParameter("CallForPrice", typeof(bool));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertActiveListing", activeListingIdParameter, ageParameter, colorParameter, damParameter, sireParameter, damSireParameter, descriptionParameter, firebaseIdParameter, genderParameter, horseNameParameter, inFoalParameter, lteParameter, originalDateListedParameter, priceParameter, purchaseListingTypeParameter, ranchPhotoParameter, sellerIdParameter, horseTypeParameter, isSoldParameter, inFoalToParameter, isRegisteredParameter, callForPriceParameter, heightParameter);
        }
    
        public virtual ObjectResult<usp_InsertSire_Result> usp_InsertSire(string name, string horseType)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var horseTypeParameter = horseType != null ?
                new ObjectParameter("horseType", horseType) :
                new ObjectParameter("horseType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_InsertSire_Result>("usp_InsertSire", nameParameter, horseTypeParameter);
        }
    
        public virtual int usp_InsertSires(string type)
        {
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertSires", typeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_RowExists(Nullable<long> row)
        {
            var rowParameter = row.HasValue ?
                new ObjectParameter("row", row) :
                new ObjectParameter("row", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_RowExists", rowParameter);
        }
    
        public virtual int usp_SearchActiveListings(Nullable<bool> typeSearch, Nullable<bool> priceSearch, Nullable<decimal> priceLow, Nullable<decimal> priceHigh, Nullable<bool> sireSearch, Nullable<bool> damSearch, Nullable<bool> damSireSearch, Nullable<bool> genderSearch, Nullable<bool> ageSearch, Nullable<bool> colorSearch, Nullable<bool> lteSearch, Nullable<decimal> lteHigh, Nullable<decimal> lteLow, Nullable<bool> inFoalSearch, Nullable<bool> inFoal, Nullable<bool> inFoalToSearch, string inFoalTo, Nullable<bool> isSoldSearch, Nullable<bool> isSold, Nullable<int> itemsPerPage, Nullable<int> page, Nullable<bool> orderBy, Nullable<int> orderByType, Nullable<bool> orderByDesc, Nullable<bool> activeListingIdSearch, Nullable<bool> heightSearch, Nullable<bool> isSireRegisteredSearch, Nullable<bool> isSireRegistered, Nullable<bool> isDamSireRegisteredSearch, Nullable<bool> isDamSireRegistered)
        {
            var typeSearchParameter = typeSearch.HasValue ?
                new ObjectParameter("TypeSearch", typeSearch) :
                new ObjectParameter("TypeSearch", typeof(bool));
    
            var priceSearchParameter = priceSearch.HasValue ?
                new ObjectParameter("PriceSearch", priceSearch) :
                new ObjectParameter("PriceSearch", typeof(bool));
    
            var priceLowParameter = priceLow.HasValue ?
                new ObjectParameter("PriceLow", priceLow) :
                new ObjectParameter("PriceLow", typeof(decimal));
    
            var priceHighParameter = priceHigh.HasValue ?
                new ObjectParameter("PriceHigh", priceHigh) :
                new ObjectParameter("PriceHigh", typeof(decimal));
    
            var sireSearchParameter = sireSearch.HasValue ?
                new ObjectParameter("SireSearch", sireSearch) :
                new ObjectParameter("SireSearch", typeof(bool));
    
            var damSearchParameter = damSearch.HasValue ?
                new ObjectParameter("DamSearch", damSearch) :
                new ObjectParameter("DamSearch", typeof(bool));
    
            var damSireSearchParameter = damSireSearch.HasValue ?
                new ObjectParameter("DamSireSearch", damSireSearch) :
                new ObjectParameter("DamSireSearch", typeof(bool));
    
            var genderSearchParameter = genderSearch.HasValue ?
                new ObjectParameter("GenderSearch", genderSearch) :
                new ObjectParameter("GenderSearch", typeof(bool));
    
            var ageSearchParameter = ageSearch.HasValue ?
                new ObjectParameter("AgeSearch", ageSearch) :
                new ObjectParameter("AgeSearch", typeof(bool));
    
            var colorSearchParameter = colorSearch.HasValue ?
                new ObjectParameter("ColorSearch", colorSearch) :
                new ObjectParameter("ColorSearch", typeof(bool));
    
            var lteSearchParameter = lteSearch.HasValue ?
                new ObjectParameter("LteSearch", lteSearch) :
                new ObjectParameter("LteSearch", typeof(bool));
    
            var lteHighParameter = lteHigh.HasValue ?
                new ObjectParameter("LteHigh", lteHigh) :
                new ObjectParameter("LteHigh", typeof(decimal));
    
            var lteLowParameter = lteLow.HasValue ?
                new ObjectParameter("LteLow", lteLow) :
                new ObjectParameter("LteLow", typeof(decimal));
    
            var inFoalSearchParameter = inFoalSearch.HasValue ?
                new ObjectParameter("InFoalSearch", inFoalSearch) :
                new ObjectParameter("InFoalSearch", typeof(bool));
    
            var inFoalParameter = inFoal.HasValue ?
                new ObjectParameter("InFoal", inFoal) :
                new ObjectParameter("InFoal", typeof(bool));
    
            var inFoalToSearchParameter = inFoalToSearch.HasValue ?
                new ObjectParameter("InFoalToSearch", inFoalToSearch) :
                new ObjectParameter("InFoalToSearch", typeof(bool));
    
            var inFoalToParameter = inFoalTo != null ?
                new ObjectParameter("InFoalTo", inFoalTo) :
                new ObjectParameter("InFoalTo", typeof(string));
    
            var isSoldSearchParameter = isSoldSearch.HasValue ?
                new ObjectParameter("IsSoldSearch", isSoldSearch) :
                new ObjectParameter("IsSoldSearch", typeof(bool));
    
            var isSoldParameter = isSold.HasValue ?
                new ObjectParameter("IsSold", isSold) :
                new ObjectParameter("IsSold", typeof(bool));
    
            var itemsPerPageParameter = itemsPerPage.HasValue ?
                new ObjectParameter("ItemsPerPage", itemsPerPage) :
                new ObjectParameter("ItemsPerPage", typeof(int));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("Page", page) :
                new ObjectParameter("Page", typeof(int));
    
            var orderByParameter = orderBy.HasValue ?
                new ObjectParameter("OrderBy", orderBy) :
                new ObjectParameter("OrderBy", typeof(bool));
    
            var orderByTypeParameter = orderByType.HasValue ?
                new ObjectParameter("OrderByType", orderByType) :
                new ObjectParameter("OrderByType", typeof(int));
    
            var orderByDescParameter = orderByDesc.HasValue ?
                new ObjectParameter("OrderByDesc", orderByDesc) :
                new ObjectParameter("OrderByDesc", typeof(bool));
    
            var activeListingIdSearchParameter = activeListingIdSearch.HasValue ?
                new ObjectParameter("ActiveListingIdSearch", activeListingIdSearch) :
                new ObjectParameter("ActiveListingIdSearch", typeof(bool));
    
            var heightSearchParameter = heightSearch.HasValue ?
                new ObjectParameter("HeightSearch", heightSearch) :
                new ObjectParameter("HeightSearch", typeof(bool));
    
            var isSireRegisteredSearchParameter = isSireRegisteredSearch.HasValue ?
                new ObjectParameter("IsSireRegisteredSearch", isSireRegisteredSearch) :
                new ObjectParameter("IsSireRegisteredSearch", typeof(bool));
    
            var isSireRegisteredParameter = isSireRegistered.HasValue ?
                new ObjectParameter("IsSireRegistered", isSireRegistered) :
                new ObjectParameter("IsSireRegistered", typeof(bool));
    
            var isDamSireRegisteredSearchParameter = isDamSireRegisteredSearch.HasValue ?
                new ObjectParameter("IsDamSireRegisteredSearch", isDamSireRegisteredSearch) :
                new ObjectParameter("IsDamSireRegisteredSearch", typeof(bool));
    
            var isDamSireRegisteredParameter = isDamSireRegistered.HasValue ?
                new ObjectParameter("IsDamSireRegistered", isDamSireRegistered) :
                new ObjectParameter("IsDamSireRegistered", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_SearchActiveListings", typeSearchParameter, priceSearchParameter, priceLowParameter, priceHighParameter, sireSearchParameter, damSearchParameter, damSireSearchParameter, genderSearchParameter, ageSearchParameter, colorSearchParameter, lteSearchParameter, lteHighParameter, lteLowParameter, inFoalSearchParameter, inFoalParameter, inFoalToSearchParameter, inFoalToParameter, isSoldSearchParameter, isSoldParameter, itemsPerPageParameter, pageParameter, orderByParameter, orderByTypeParameter, orderByDescParameter, activeListingIdSearchParameter, heightSearchParameter, isSireRegisteredSearchParameter, isSireRegisteredParameter, isDamSireRegisteredSearchParameter, isDamSireRegisteredParameter);
        }
    
        public virtual ObjectResult<usp_SearchAllSires_Result> usp_SearchAllSires(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SearchAllSires_Result>("usp_SearchAllSires", nameParameter);
        }
    
        public virtual int usp_SearchAllSiresElastically(Nullable<bool> nameSearch, Nullable<bool> horseTypeSearch, string name, Nullable<int> page, Nullable<int> itemsPerPage)
        {
            var nameSearchParameter = nameSearch.HasValue ?
                new ObjectParameter("NameSearch", nameSearch) :
                new ObjectParameter("NameSearch", typeof(bool));
    
            var horseTypeSearchParameter = horseTypeSearch.HasValue ?
                new ObjectParameter("HorseTypeSearch", horseTypeSearch) :
                new ObjectParameter("HorseTypeSearch", typeof(bool));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("Page", page) :
                new ObjectParameter("Page", typeof(int));
    
            var itemsPerPageParameter = itemsPerPage.HasValue ?
                new ObjectParameter("ItemsPerPage", itemsPerPage) :
                new ObjectParameter("ItemsPerPage", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_SearchAllSiresElastically", nameSearchParameter, horseTypeSearchParameter, nameParameter, pageParameter, itemsPerPageParameter);
        }
    
        public virtual int usp_UpdateActiveListing(string activeListingId, Nullable<int> age, string color, string dam, string sire, string damSire, string description, string gender, string horseName, Nullable<bool> inFoal, Nullable<decimal> lte, Nullable<System.DateTime> originalDateListed, Nullable<decimal> price, string purchaseListingType, string ranchPhoto, string sellerId, string horseType, Nullable<bool> isSold, string inFoalTo, Nullable<bool> callForPrice, Nullable<double> height)
        {
            var activeListingIdParameter = activeListingId != null ?
                new ObjectParameter("ActiveListingId", activeListingId) :
                new ObjectParameter("ActiveListingId", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var damParameter = dam != null ?
                new ObjectParameter("Dam", dam) :
                new ObjectParameter("Dam", typeof(string));
    
            var sireParameter = sire != null ?
                new ObjectParameter("Sire", sire) :
                new ObjectParameter("Sire", typeof(string));
    
            var damSireParameter = damSire != null ?
                new ObjectParameter("DamSire", damSire) :
                new ObjectParameter("DamSire", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var horseNameParameter = horseName != null ?
                new ObjectParameter("HorseName", horseName) :
                new ObjectParameter("HorseName", typeof(string));
    
            var inFoalParameter = inFoal.HasValue ?
                new ObjectParameter("InFoal", inFoal) :
                new ObjectParameter("InFoal", typeof(bool));
    
            var lteParameter = lte.HasValue ?
                new ObjectParameter("Lte", lte) :
                new ObjectParameter("Lte", typeof(decimal));
    
            var originalDateListedParameter = originalDateListed.HasValue ?
                new ObjectParameter("OriginalDateListed", originalDateListed) :
                new ObjectParameter("OriginalDateListed", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var purchaseListingTypeParameter = purchaseListingType != null ?
                new ObjectParameter("PurchaseListingType", purchaseListingType) :
                new ObjectParameter("PurchaseListingType", typeof(string));
    
            var ranchPhotoParameter = ranchPhoto != null ?
                new ObjectParameter("RanchPhoto", ranchPhoto) :
                new ObjectParameter("RanchPhoto", typeof(string));
    
            var sellerIdParameter = sellerId != null ?
                new ObjectParameter("SellerId", sellerId) :
                new ObjectParameter("SellerId", typeof(string));
    
            var horseTypeParameter = horseType != null ?
                new ObjectParameter("HorseType", horseType) :
                new ObjectParameter("HorseType", typeof(string));
    
            var isSoldParameter = isSold.HasValue ?
                new ObjectParameter("IsSold", isSold) :
                new ObjectParameter("IsSold", typeof(bool));
    
            var inFoalToParameter = inFoalTo != null ?
                new ObjectParameter("InFoalTo", inFoalTo) :
                new ObjectParameter("InFoalTo", typeof(string));
    
            var callForPriceParameter = callForPrice.HasValue ?
                new ObjectParameter("CallForPrice", callForPrice) :
                new ObjectParameter("CallForPrice", typeof(bool));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateActiveListing", activeListingIdParameter, ageParameter, colorParameter, damParameter, sireParameter, damSireParameter, descriptionParameter, genderParameter, horseNameParameter, inFoalParameter, lteParameter, originalDateListedParameter, priceParameter, purchaseListingTypeParameter, ranchPhotoParameter, sellerIdParameter, horseTypeParameter, isSoldParameter, inFoalToParameter, callForPriceParameter, heightParameter);
        }
    
        public virtual ObjectResult<usp_UpdateSireName_Result> usp_UpdateSireName(string oldName, string newName)
        {
            var oldNameParameter = oldName != null ?
                new ObjectParameter("oldName", oldName) :
                new ObjectParameter("oldName", typeof(string));
    
            var newNameParameter = newName != null ?
                new ObjectParameter("newName", newName) :
                new ObjectParameter("newName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UpdateSireName_Result>("usp_UpdateSireName", oldNameParameter, newNameParameter);
        }
    }
}
