﻿using Shared;

namespace FS.TechDemo.BuyerBFF.GraphQL.Types.Order;


// OrderResponse is the GRPC autogenerated type
public class OrderType : ObjectTypeBase<OrderResponse>
{
    protected override void Configure(IObjectTypeDescriptor<OrderResponse> descriptor)
    {
        base.Configure(descriptor);
        
        descriptor.Field(context => context.Id).Description("Id of the Order");
        descriptor.Field(context => context.Name).Description("Name of the Order");
        descriptor.Field(context => context.Number).Description("Order Number from SAP");
        descriptor.Field(context => context.Total).Description("Total price over all items");
    }
}