﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

using System;

namespace Debugger.Tests.TestPrograms
{
	public class DebugTypes
	{
		public struct Point {
			int x;
			int y;
		}
		
		public static unsafe void Main()
		{
			int loc = 42;
			int locByRef = 43;
			int* locPtr = &loc;
			int* locPtrByRef = &loc;
			int** locPtrPtr = &locPtr;
		    void* locVoidPtr = &loc;
		    object locObj = new object();
		    object locObjByRef = new object();
		    char[] locSZArray = "Test".ToCharArray();
		    char[,] locArray = new char[2,2];
		    Point locStruct;
		    Point* locStructPtr = &locStruct;
		    
		    System.Diagnostics.Debugger.Break();
		    
			Fun(loc, ref locByRef, locPtr, ref locPtrByRef,
		        locPtrPtr, locVoidPtr,
		        locObj, ref locObjByRef,
		        locSZArray, locArray,
		        locStruct, ref locStruct, locStructPtr);
		}
		
		static unsafe void Fun(int arg, ref int argByRef, int* argPtr, ref int* argPtrByRef,
		                       int** argPtrPtr, void* argVoidPtr,
		                       object argObj, ref object argObjByRef,
		                       char[] argSZArray, char[,] argArray,
		                       Point argStruct, ref Point argStructByRef, Point* argStructPtr)
		{
			System.Diagnostics.Debugger.Break();
		}
	}
}

#if TEST_CODE
namespace Debugger.Tests {
	public partial class DebuggerTests
	{
		[NUnit.Framework.Test]
		public void DebugTypes()
		{
			ExpandProperties(
				"Value.Type",
				"DebubType.BaseType"
			);
			StartTest("DebugTypes.cs");
			ObjectDump("LocalVariables", process.SelectedStackFrame.GetLocalVariableValues());
			process.Continue();
			ObjectDump("Arguments", process.SelectedStackFrame.GetArgumentValues());
			EndTest();
		}
	}
}
#endif

#if EXPECTED_OUTPUT
<?xml version="1.0" encoding="utf-8"?>
<DebuggerTests>
  <Test
    name="DebugTypes.cs">
    <ProcessStarted />
    <ModuleLoaded>mscorlib.dll (No symbols)</ModuleLoaded>
    <ModuleLoaded>DebugTypes.exe (Has symbols)</ModuleLoaded>
    <DebuggingPaused>Break</DebuggingPaused>
    <LocalVariables
      Capacity="16"
      Count="12">
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="loc"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="43"
          Expression="locByRef"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="43"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="locPtr"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="locPtrByRef"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="locPtrPtr"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="null"
          Expression="locVoidPtr"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="True"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{System.Object}"
          Expression="locObj"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{System.Object}"
          Expression="locObjByRef"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="[4]"
          ArrayLenght="4"
          ArrayRank="1"
          AsString="{System.Char[]}"
          Expression="locSZArray"
          IsArray="True"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Char[]">
          <Type>
            <DebugType
              BaseType="System.Array"
              FullName="System.Char[]"
              HasElementType="True"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="True"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="System.Array"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="[2, 2]"
          ArrayLenght="4"
          ArrayRank="2"
          AsString="{System.Char[,]}"
          Expression="locArray"
          IsArray="True"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Char[,]">
          <Type>
            <DebugType
              BaseType="System.Array"
              FullName="System.Char[,]"
              HasElementType="True"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="True"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="System.Array"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{Point}"
          Expression="locStruct"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="Point">
          <Type>
            <DebugType
              BaseType="System.ValueType"
              FullName="Point"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="True"
              ManagedType="null"
              Module="DebugTypes.exe" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{Point}"
          Expression="locStructPtr"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="Point">
          <Type>
            <DebugType
              BaseType="System.ValueType"
              FullName="Point"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="True"
              ManagedType="null"
              Module="DebugTypes.exe" />
          </Type>
        </Value>
      </Item>
    </LocalVariables>
    <DebuggingPaused>Break</DebuggingPaused>
    <Arguments
      Capacity="16"
      Count="13">
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="arg"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="43"
          Expression="argByRef"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="43"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="argPtr"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="argPtrByRef"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="42"
          Expression="argPtrPtr"
          IsArray="False"
          IsInteger="True"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="True"
          PrimitiveValue="42"
          Type="System.Int32">
          <Type>
            <DebugType
              BaseType="System.Object"
              FullName="System.Int32"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="True"
              IsInterface="False"
              IsPrimitive="True"
              IsValueType="False"
              ManagedType="System.Int32"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="null"
          Expression="argVoidPtr"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="True"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{System.Object}"
          Expression="argObj"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{System.Object}"
          Expression="argObjByRef"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Object">
          <Type>
            <DebugType
              BaseType="null"
              FullName="System.Object"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="True"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="null"
              Module="mscorlib.dll" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="[4]"
          ArrayLenght="4"
          ArrayRank="1"
          AsString="{System.Char[]}"
          Expression="argSZArray"
          IsArray="True"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Char[]">
          <Type>
            <DebugType
              BaseType="System.Array"
              FullName="System.Char[]"
              HasElementType="True"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="True"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="System.Array"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="[2, 2]"
          ArrayLenght="4"
          ArrayRank="2"
          AsString="{System.Char[,]}"
          Expression="argArray"
          IsArray="True"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="False"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="System.Char[,]">
          <Type>
            <DebugType
              BaseType="System.Array"
              FullName="System.Char[,]"
              HasElementType="True"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="True"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="False"
              ManagedType="System.Array"
              Module="{Exception: The type is not a class or value type.}" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{Point}"
          Expression="argStruct"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="Point">
          <Type>
            <DebugType
              BaseType="System.ValueType"
              FullName="Point"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="True"
              ManagedType="null"
              Module="DebugTypes.exe" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{Point}"
          Expression="argStructByRef"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="Point">
          <Type>
            <DebugType
              BaseType="System.ValueType"
              FullName="Point"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="True"
              ManagedType="null"
              Module="DebugTypes.exe" />
          </Type>
        </Value>
      </Item>
      <Item>
        <Value
          ArrayDimensions="{Exception: Value is not an array}"
          ArrayLenght="{Exception: Value is not an array}"
          ArrayRank="{Exception: Value is not an array}"
          AsString="{Point}"
          Expression="argStructPtr"
          IsArray="False"
          IsInteger="False"
          IsInvalid="False"
          IsNull="False"
          IsObject="True"
          IsPrimitive="False"
          PrimitiveValue="{Exception: Value is not a primitive type}"
          Type="Point">
          <Type>
            <DebugType
              BaseType="System.ValueType"
              FullName="Point"
              HasElementType="False"
              Interfaces="System.Collections.Generic.List`1[Debugger.MetaData.DebugType]"
              IsArray="False"
              IsClass="False"
              IsGenericType="False"
              IsInteger="False"
              IsInterface="False"
              IsPrimitive="False"
              IsValueType="True"
              ManagedType="null"
              Module="DebugTypes.exe" />
          </Type>
        </Value>
      </Item>
    </Arguments>
    <ProcessExited />
  </Test>
</DebuggerTests>
#endif // EXPECTED_OUTPUT