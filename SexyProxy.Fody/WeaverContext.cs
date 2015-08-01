﻿using System;
using Mono.Cecil;

namespace SexyProxy.Fody
{
    public class WeaverContext
    {
        public ModuleDefinition ModuleDefinition { get; set; }
        public Action<string> LogInfo { get; set; }
        public Action<string> LogError { get; set; }
        public Action<string> LogWarning { get; set; }
        public AssemblyNameReference SexyProxy { get; set; } 
        public TypeReference MethodInfoType { get; set; }
        public TypeReference Func2Type { get; set; }
        public TypeReference Action1Type { get; set; }
        public TypeReference ObjectArrayType { get; set; }
        public TypeReference TaskType { get; set; }
        public TypeReference InvocationTType { get; set; }
        public TypeReference AsyncInvocationTType { get; set; }
        public TypeReference InvocationHandlerType { get; set; }
        public MethodReference VoidInvocationConstructor { get; set; }
        public MethodReference VoidAsyncInvocationConstructor { get; set; }
        public MethodReference VoidInvokeMethod { get; set; }
        public MethodReference AsyncVoidInvokeMethod { get; set; }
        public MethodReference InvokeTMethod { get; set; }
        public MethodReference AsyncInvokeTMethod { get; set; }
        public TypeReference ObjectType { get; set; }
    }
}