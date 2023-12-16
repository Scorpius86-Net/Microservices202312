// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Products.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Microservices.gRPC.API.Protos {
  public static partial class Products
  {
    static readonly string __ServiceName = "product.Products";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.Empty> __Marshaller_product_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.ListResponse> __Marshaller_product_ListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.ListResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.GetByIdRequest> __Marshaller_product_GetByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.GetByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.GetByIdResponse> __Marshaller_product_GetByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.GetByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.InsertRequest> __Marshaller_product_InsertRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.InsertRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.UpdateRequest> __Marshaller_product_UpdateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.UpdateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Microservices.gRPC.API.Protos.DeleteRequest> __Marshaller_product_DeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservices.gRPC.API.Protos.DeleteRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Microservices.gRPC.API.Protos.Empty, global::Microservices.gRPC.API.Protos.ListResponse> __Method_List = new grpc::Method<global::Microservices.gRPC.API.Protos.Empty, global::Microservices.gRPC.API.Protos.ListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_product_Empty,
        __Marshaller_product_ListResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Microservices.gRPC.API.Protos.GetByIdRequest, global::Microservices.gRPC.API.Protos.GetByIdResponse> __Method_GetById = new grpc::Method<global::Microservices.gRPC.API.Protos.GetByIdRequest, global::Microservices.gRPC.API.Protos.GetByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_product_GetByIdRequest,
        __Marshaller_product_GetByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Microservices.gRPC.API.Protos.InsertRequest, global::Microservices.gRPC.API.Protos.Empty> __Method_Insert = new grpc::Method<global::Microservices.gRPC.API.Protos.InsertRequest, global::Microservices.gRPC.API.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_product_InsertRequest,
        __Marshaller_product_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Microservices.gRPC.API.Protos.UpdateRequest, global::Microservices.gRPC.API.Protos.Empty> __Method_Update = new grpc::Method<global::Microservices.gRPC.API.Protos.UpdateRequest, global::Microservices.gRPC.API.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_product_UpdateRequest,
        __Marshaller_product_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Microservices.gRPC.API.Protos.DeleteRequest, global::Microservices.gRPC.API.Protos.Empty> __Method_Delete = new grpc::Method<global::Microservices.gRPC.API.Protos.DeleteRequest, global::Microservices.gRPC.API.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_product_DeleteRequest,
        __Marshaller_product_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Microservices.gRPC.API.Protos.ProductsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Products</summary>
    [grpc::BindServiceMethod(typeof(Products), "BindService")]
    public abstract partial class ProductsBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Microservices.gRPC.API.Protos.ListResponse> List(global::Microservices.gRPC.API.Protos.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Microservices.gRPC.API.Protos.GetByIdResponse> GetById(global::Microservices.gRPC.API.Protos.GetByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Microservices.gRPC.API.Protos.Empty> Insert(global::Microservices.gRPC.API.Protos.InsertRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Microservices.gRPC.API.Protos.Empty> Update(global::Microservices.gRPC.API.Protos.UpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Microservices.gRPC.API.Protos.Empty> Delete(global::Microservices.gRPC.API.Protos.DeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_List, serviceImpl.List)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_List, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservices.gRPC.API.Protos.Empty, global::Microservices.gRPC.API.Protos.ListResponse>(serviceImpl.List));
      serviceBinder.AddMethod(__Method_GetById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservices.gRPC.API.Protos.GetByIdRequest, global::Microservices.gRPC.API.Protos.GetByIdResponse>(serviceImpl.GetById));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservices.gRPC.API.Protos.InsertRequest, global::Microservices.gRPC.API.Protos.Empty>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservices.gRPC.API.Protos.UpdateRequest, global::Microservices.gRPC.API.Protos.Empty>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservices.gRPC.API.Protos.DeleteRequest, global::Microservices.gRPC.API.Protos.Empty>(serviceImpl.Delete));
    }

  }
}
#endregion