// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserProto {
  public static partial class UserService
  {
    static readonly string __ServiceName = "user.UserService";

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
    static readonly grpc::Marshaller<global::UserProto.GetByRUT> __Marshaller_user_GetByRUT = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.GetByRUT.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserProto.UserResponse> __Marshaller_user_UserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.UserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserProto.UpdateUser> __Marshaller_user_UpdateUser = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.UpdateUser.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserProto.Empty> __Marshaller_user_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserProto.ValidateRequest> __Marshaller_user_ValidateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.ValidateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserProto.CreateUserRequest> __Marshaller_user_CreateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserProto.CreateUserRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.GetByRUT, global::UserProto.UserResponse> __Method_profile = new grpc::Method<global::UserProto.GetByRUT, global::UserProto.UserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "profile",
        __Marshaller_user_GetByRUT,
        __Marshaller_user_UserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.UpdateUser, global::UserProto.Empty> __Method_updateProfile = new grpc::Method<global::UserProto.UpdateUser, global::UserProto.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateProfile",
        __Marshaller_user_UpdateUser,
        __Marshaller_user_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.Empty, global::UserProto.Empty> __Method_GetMyProgress = new grpc::Method<global::UserProto.Empty, global::UserProto.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMyProgress",
        __Marshaller_user_Empty,
        __Marshaller_user_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.Empty, global::UserProto.Empty> __Method_PatchMyProgress = new grpc::Method<global::UserProto.Empty, global::UserProto.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PatchMyProgress",
        __Marshaller_user_Empty,
        __Marshaller_user_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.ValidateRequest, global::UserProto.Empty> __Method_UpdatePassword = new grpc::Method<global::UserProto.ValidateRequest, global::UserProto.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePassword",
        __Marshaller_user_ValidateRequest,
        __Marshaller_user_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserProto.CreateUserRequest, global::UserProto.Empty> __Method_CreateUser = new grpc::Method<global::UserProto.CreateUserRequest, global::UserProto.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateUser",
        __Marshaller_user_CreateUserRequest,
        __Marshaller_user_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserProto.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserService</summary>
    [grpc::BindServiceMethod(typeof(UserService), "BindService")]
    public abstract partial class UserServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.UserResponse> profile(global::UserProto.GetByRUT request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.Empty> updateProfile(global::UserProto.UpdateUser request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.Empty> GetMyProgress(global::UserProto.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.Empty> PatchMyProgress(global::UserProto.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.Empty> UpdatePassword(global::UserProto.ValidateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserProto.Empty> CreateUser(global::UserProto.CreateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_profile, serviceImpl.profile)
          .AddMethod(__Method_updateProfile, serviceImpl.updateProfile)
          .AddMethod(__Method_GetMyProgress, serviceImpl.GetMyProgress)
          .AddMethod(__Method_PatchMyProgress, serviceImpl.PatchMyProgress)
          .AddMethod(__Method_UpdatePassword, serviceImpl.UpdatePassword)
          .AddMethod(__Method_CreateUser, serviceImpl.CreateUser).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_profile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.GetByRUT, global::UserProto.UserResponse>(serviceImpl.profile));
      serviceBinder.AddMethod(__Method_updateProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.UpdateUser, global::UserProto.Empty>(serviceImpl.updateProfile));
      serviceBinder.AddMethod(__Method_GetMyProgress, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.Empty, global::UserProto.Empty>(serviceImpl.GetMyProgress));
      serviceBinder.AddMethod(__Method_PatchMyProgress, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.Empty, global::UserProto.Empty>(serviceImpl.PatchMyProgress));
      serviceBinder.AddMethod(__Method_UpdatePassword, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.ValidateRequest, global::UserProto.Empty>(serviceImpl.UpdatePassword));
      serviceBinder.AddMethod(__Method_CreateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserProto.CreateUserRequest, global::UserProto.Empty>(serviceImpl.CreateUser));
    }

  }
}
#endregion