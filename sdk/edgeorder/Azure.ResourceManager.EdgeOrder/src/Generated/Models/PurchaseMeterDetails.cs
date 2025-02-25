// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Billing type Purchase meter details. </summary>
    public partial class PurchaseMeterDetails : EdgeOrderProductMeterDetails
    {
        /// <summary> Initializes a new instance of <see cref="PurchaseMeterDetails"/>. </summary>
        internal PurchaseMeterDetails()
        {
            BillingType = BillingType.Purchase;
        }

        /// <summary> Initializes a new instance of <see cref="PurchaseMeterDetails"/>. </summary>
        /// <param name="billingType"> Represents billing type. </param>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <param name="productId"> Product Id. </param>
        /// <param name="skuId"> Sku Id. </param>
        /// <param name="termId"> Term Id. </param>
        internal PurchaseMeterDetails(BillingType billingType, double? multiplier, EdgeOrderProductChargingType? chargingType, string productId, string skuId, string termId) : base(billingType, multiplier, chargingType)
        {
            ProductId = productId;
            SkuId = skuId;
            TermId = termId;
            BillingType = billingType;
        }

        /// <summary> Product Id. </summary>
        public string ProductId { get; }
        /// <summary> Sku Id. </summary>
        public string SkuId { get; }
        /// <summary> Term Id. </summary>
        public string TermId { get; }
    }
}
