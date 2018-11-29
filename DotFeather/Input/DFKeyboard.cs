﻿using OpenTK.Input;

namespace DotFeather
{
	/// <summary>
	/// キーボード入力
	/// </summary>
	public class DFKeyboard
	{
		public DFKey Unknown { get; } = new DFKey(Key.Unknown);
		public DFKey ShiftLeft { get; } = new DFKey(Key.ShiftLeft);
		public DFKey LShift { get; } = new DFKey(Key.LShift);
		public DFKey ShiftRight { get; } = new DFKey(Key.ShiftRight);
		public DFKey RShift { get; } = new DFKey(Key.RShift);
		public DFKey ControlLeft { get; } = new DFKey(Key.ControlLeft);
		public DFKey LControl { get; } = new DFKey(Key.LControl);
		public DFKey ControlRight { get; } = new DFKey(Key.ControlRight);
		public DFKey RControl { get; } = new DFKey(Key.RControl);
		public DFKey AltLeft { get; } = new DFKey(Key.AltLeft);
		public DFKey LAlt { get; } = new DFKey(Key.LAlt);
		public DFKey AltRight { get; } = new DFKey(Key.AltRight);
		public DFKey RAlt { get; } = new DFKey(Key.RAlt);
		public DFKey WinLeft { get; } = new DFKey(Key.WinLeft);
		public DFKey LWin { get; } = new DFKey(Key.LWin);
		public DFKey WinRight { get; } = new DFKey(Key.WinRight);
		public DFKey RWin { get; } = new DFKey(Key.RWin);
		public DFKey Menu { get; } = new DFKey(Key.Menu);
		public DFKey F1 { get; } = new DFKey(Key.F1);
		public DFKey F2 { get; } = new DFKey(Key.F2);
		public DFKey F3 { get; } = new DFKey(Key.F3);
		public DFKey F4 { get; } = new DFKey(Key.F4);
		public DFKey F5 { get; } = new DFKey(Key.F5);
		public DFKey F6 { get; } = new DFKey(Key.F6);
		public DFKey F7 { get; } = new DFKey(Key.F7);
		public DFKey F8 { get; } = new DFKey(Key.F8);
		public DFKey F9 { get; } = new DFKey(Key.F9);
		public DFKey F10 { get; } = new DFKey(Key.F10);
		public DFKey F11 { get; } = new DFKey(Key.F11);
		public DFKey F12 { get; } = new DFKey(Key.F12);
		public DFKey F13 { get; } = new DFKey(Key.F13);
		public DFKey F14 { get; } = new DFKey(Key.F14);
		public DFKey F15 { get; } = new DFKey(Key.F15);
		public DFKey F16 { get; } = new DFKey(Key.F16);
		public DFKey F17 { get; } = new DFKey(Key.F17);
		public DFKey F18 { get; } = new DFKey(Key.F18);
		public DFKey F19 { get; } = new DFKey(Key.F19);
		public DFKey F20 { get; } = new DFKey(Key.F20);
		public DFKey F21 { get; } = new DFKey(Key.F21);
		public DFKey F22 { get; } = new DFKey(Key.F22);
		public DFKey F23 { get; } = new DFKey(Key.F23);
		public DFKey F24 { get; } = new DFKey(Key.F24);
		public DFKey F25 { get; } = new DFKey(Key.F25);
		public DFKey F26 { get; } = new DFKey(Key.F26);
		public DFKey F27 { get; } = new DFKey(Key.F27);
		public DFKey F28 { get; } = new DFKey(Key.F28);
		public DFKey F29 { get; } = new DFKey(Key.F29);
		public DFKey F30 { get; } = new DFKey(Key.F30);
		public DFKey F31 { get; } = new DFKey(Key.F31);
		public DFKey F32 { get; } = new DFKey(Key.F32);
		public DFKey F33 { get; } = new DFKey(Key.F33);
		public DFKey F34 { get; } = new DFKey(Key.F34);
		public DFKey F35 { get; } = new DFKey(Key.F35);
		public DFKey Up { get; } = new DFKey(Key.Up);
		public DFKey Down { get; } = new DFKey(Key.Down);
		public DFKey Left { get; } = new DFKey(Key.Left);
		public DFKey Right { get; } = new DFKey(Key.Right);
		public DFKey Enter { get; } = new DFKey(Key.Enter);
		public DFKey Escape { get; } = new DFKey(Key.Escape);
		public DFKey Space { get; } = new DFKey(Key.Space);
		public DFKey Tab { get; } = new DFKey(Key.Tab);
		public DFKey BackSpace { get; } = new DFKey(Key.BackSpace);
		public DFKey Back { get; } = new DFKey(Key.Back);
		public DFKey Insert { get; } = new DFKey(Key.Insert);
		public DFKey Delete { get; } = new DFKey(Key.Delete);
		public DFKey PageUp { get; } = new DFKey(Key.PageUp);
		public DFKey PageDown { get; } = new DFKey(Key.PageDown);
		public DFKey Home { get; } = new DFKey(Key.Home);
		public DFKey End { get; } = new DFKey(Key.End);
		public DFKey CapsLock { get; } = new DFKey(Key.CapsLock);
		public DFKey ScrollLock { get; } = new DFKey(Key.ScrollLock);
		public DFKey PrintScreen { get; } = new DFKey(Key.PrintScreen);
		public DFKey Pause { get; } = new DFKey(Key.Pause);
		public DFKey NumLock { get; } = new DFKey(Key.NumLock);
		public DFKey Clear { get; } = new DFKey(Key.Clear);
		public DFKey Sleep { get; } = new DFKey(Key.Sleep);
		public DFKey Keypad0 { get; } = new DFKey(Key.Keypad0);
		public DFKey Keypad1 { get; } = new DFKey(Key.Keypad1);
		public DFKey Keypad2 { get; } = new DFKey(Key.Keypad2);
		public DFKey Keypad3 { get; } = new DFKey(Key.Keypad3);
		public DFKey Keypad4 { get; } = new DFKey(Key.Keypad4);
		public DFKey Keypad5 { get; } = new DFKey(Key.Keypad5);
		public DFKey Keypad6 { get; } = new DFKey(Key.Keypad6);
		public DFKey Keypad7 { get; } = new DFKey(Key.Keypad7);
		public DFKey Keypad8 { get; } = new DFKey(Key.Keypad8);
		public DFKey Keypad9 { get; } = new DFKey(Key.Keypad9);
		public DFKey KeypadDivide { get; } = new DFKey(Key.KeypadDivide);
		public DFKey KeypadMultiply { get; } = new DFKey(Key.KeypadMultiply);
		public DFKey KeypadSubtract { get; } = new DFKey(Key.KeypadSubtract);
		public DFKey KeypadMinus { get; } = new DFKey(Key.KeypadMinus);
		public DFKey KeypadAdd { get; } = new DFKey(Key.KeypadAdd);
		public DFKey KeypadPlus { get; } = new DFKey(Key.KeypadPlus);
		public DFKey KeypadDecimal { get; } = new DFKey(Key.KeypadDecimal);
		public DFKey KeypadPeriod { get; } = new DFKey(Key.KeypadPeriod);
		public DFKey KeypadEnter { get; } = new DFKey(Key.KeypadEnter);
		public DFKey A { get; } = new DFKey(Key.A);
		public DFKey B { get; } = new DFKey(Key.B);
		public DFKey C { get; } = new DFKey(Key.C);
		public DFKey D { get; } = new DFKey(Key.D);
		public DFKey E { get; } = new DFKey(Key.E);
		public DFKey F { get; } = new DFKey(Key.F);
		public DFKey G { get; } = new DFKey(Key.G);
		public DFKey H { get; } = new DFKey(Key.H);
		public DFKey I { get; } = new DFKey(Key.I);
		public DFKey J { get; } = new DFKey(Key.J);
		public DFKey K { get; } = new DFKey(Key.K);
		public DFKey L { get; } = new DFKey(Key.L);
		public DFKey M { get; } = new DFKey(Key.M);
		public DFKey N { get; } = new DFKey(Key.N);
		public DFKey O { get; } = new DFKey(Key.O);
		public DFKey P { get; } = new DFKey(Key.P);
		public DFKey Q { get; } = new DFKey(Key.Q);
		public DFKey R { get; } = new DFKey(Key.R);
		public DFKey S { get; } = new DFKey(Key.S);
		public DFKey T { get; } = new DFKey(Key.T);
		public DFKey U { get; } = new DFKey(Key.U);
		public DFKey V { get; } = new DFKey(Key.V);
		public DFKey W { get; } = new DFKey(Key.W);
		public DFKey X { get; } = new DFKey(Key.X);
		public DFKey Y { get; } = new DFKey(Key.Y);
		public DFKey Z { get; } = new DFKey(Key.Z);
		public DFKey Number0 { get; } = new DFKey(Key.Number0);
		public DFKey Number1 { get; } = new DFKey(Key.Number1);
		public DFKey Number2 { get; } = new DFKey(Key.Number2);
		public DFKey Number3 { get; } = new DFKey(Key.Number3);
		public DFKey Number4 { get; } = new DFKey(Key.Number4);
		public DFKey Number5 { get; } = new DFKey(Key.Number5);
		public DFKey Number6 { get; } = new DFKey(Key.Number6);
		public DFKey Number7 { get; } = new DFKey(Key.Number7);
		public DFKey Number8 { get; } = new DFKey(Key.Number8);
		public DFKey Number9 { get; } = new DFKey(Key.Number9);
		public DFKey Tilde { get; } = new DFKey(Key.Tilde);
		public DFKey Grave { get; } = new DFKey(Key.Grave);
		public DFKey Minus { get; } = new DFKey(Key.Minus);
		public DFKey Plus { get; } = new DFKey(Key.Plus);
		public DFKey BracketLeft { get; } = new DFKey(Key.BracketLeft);
		public DFKey LBracket { get; } = new DFKey(Key.LBracket);
		public DFKey BracketRight { get; } = new DFKey(Key.BracketRight);
		public DFKey RBracket { get; } = new DFKey(Key.RBracket);
		public DFKey Semicolon { get; } = new DFKey(Key.Semicolon);
		public DFKey Quote { get; } = new DFKey(Key.Quote);
		public DFKey Comma { get; } = new DFKey(Key.Comma);
		public DFKey Period { get; } = new DFKey(Key.Period);
		public DFKey Slash { get; } = new DFKey(Key.Slash);
		public DFKey BackSlash { get; } = new DFKey(Key.BackSlash);
		public DFKey NonUSBackSlash { get; } = new DFKey(Key.NonUSBackSlash);
		public DFKey LastKey { get; } = new DFKey(Key.LastKey);
	}

}
