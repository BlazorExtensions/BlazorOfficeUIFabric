interface DotNetType {
  invokeMethod<T>(assemblyName: string, methodIdentifier: string, ...args: any[]): T;
  invokeMethodAsync<T>(assemblyName: string, methodIdentifier: string, ...args: any[]): Promise<T>;
}

interface DotNetReferenceType  {

  invokeMethod<T>(methodIdentifier: string, ...args: any[]): T;
  invokeMethodAsync<T>(methodIdentifier: string, ...args: any[]): Promise<T>;
}


declare var DotNet: DotNetType;
