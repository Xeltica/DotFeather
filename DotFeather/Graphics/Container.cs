using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenTK.Graphics.OpenGL;

namespace DotFeather
{
	/// <summary>
	/// 他の <see cref="IDrawable"/> オブジェクトを格納し、相対位置に描画するオブジェクトです。
	/// </summary>
	public class Container : IDrawable, IUpdatable, IList<IDrawable>
	{
		/// <summary>
		/// この <see cref="T:DotFeather.Drawable.IDrawable"/> の描画優先順位を取得または設定します。数値が低いほど奥に描画されます。
		/// </summary>
		public int ZOrder { get; set; }

		/// <summary>
		/// この <see cref="T:DotFeather.Drawable.IDrawable"/> の名前を取得または設定します。
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// この <see cref="T:DotFeather.Drawable.IDrawable"/> の座標を取得または設定します。
		/// </summary>
		public Vector Location { get; set; }

		/// <summary>
		/// この <see cref="T:DotFeather.Drawable.IDrawable"/> の角度を取得または設定します。
		/// </summary>
		public float Angle { get; set; }

		/// <summary>
		/// Get or set scale of this <see cref="T:DotFeather.Drawable.IDrawable"/>.
		/// </summary>
		public Vector Scale { get; set; } = new Vector(1, 1);

		/// <summary>
		/// Get or set width of this <see cref="T:DotFeather.Drawable.IDrawable"/>.
		/// </summary>
		public int Width { get; set; } = 256;

		/// <summary>
		/// Get or set height of this <see cref="T:DotFeather.Drawable.IDrawable"/>.
		/// </summary>
		public int Height { get; set; } = 256;

		/// <summary>
		/// Get or set whether this container is trimmable. If true, this container draws children with trimming within rectangular range of this container.
		/// </summary>
		public bool IsTrimmable { get; set; }

		/// <summary>
		/// このコンテナーの子要素にアクセスします。
		/// </summary>
		/// <param name="index">インデックス。</param>
		/// <returns>子要素</returns>
		public IDrawable this[int index]
		{
			get => Children[index];
			set => Children[index] = value;
		}

		/// <summary>
		/// コンテナをソートします。
		/// </summary>
		public void Sort() =>
			Children.Sort((d1, d2) => d1.ZOrder < d2.ZOrder ? 1 : d1.ZOrder > d2.ZOrder ? -1 : 0);

		/// <summary>
		/// このコンテナに子要素を追加します。
		/// </summary>
		/// <param name="child">子要素。</param>
		public void Add(IDrawable child)
		{
			Children.Add(child);
		}

		/// <summary>
		/// このコンテナに子要素を挿入します。
		/// </summary>
		/// <param name="index">挿入先の位置。</param>
		/// <param name="item">子要素。</param>
		public void Insert(int index, IDrawable item)
		{
			Children.Insert(index, item);
		}

		/// <summary>
		/// 描画を開始します。
		/// </summary>
		public void Draw(GameBase game, Vector location)
		{
			Sort();

			if (IsTrimmable)
			{
				var left = (VectorInt)(Location + location);
				var size = (VectorInt)(new Vector(Width, Height) * Scale);

				if (left.X < 0) left.X = 0;
				if (left.Y < 0) left.Y = 0;

				if (left.X + size.X > game.Width)
					size.X = left.X + size.X - game.Width;

				if (left.Y + size.Y > game.Height)
					size.Y = left.Y + size.Y - game.Height;

				left.Y = game.Height - left.Y - size.Y;

				GL.Scissor(left.X, left.Y, size.X, size.Y);
			}

			for (var i = this.Count - 1; i >= 0; i--)
			{
				if (this.Count - 1 < i)
					continue;
				// 位置を調整
				var baseLoc = this[i].Location;
				var baseScale = this[i].Scale;
				this[i].Scale *= Scale;
				this[i].Location *= Scale;

				this[i].Draw(game, Location + location);

				// 戻す
				this[i].Scale = baseScale;
				this[i].Location = baseLoc;
			}

			if (IsTrimmable)
				GL.Scissor(0, 0, game.Width, game.Height);
		}

		public void OnUpdate(GameBase game)
		{
			this.OfType<IUpdatable>().ToList().ForEach(u => u.OnUpdate(game));
		}

		/// <summary>
		/// この <see cref="Container"/> を破棄します。
		/// </summary>
		public void Destroy() => Clear();

		/// <summary>
		/// 列挙子を取得します。
		/// </summary>
		public IEnumerator<IDrawable> GetEnumerator() => Children.GetEnumerator();

		#region other inherited members
		/// <summary>
		/// 指定した要素の位置を取得します。
		/// </summary>
		public int IndexOf(IDrawable item) => Children.IndexOf(item);

		/// <summary>
		/// 指定した位置にあるオブジェクトを削除します。
		/// </summary>
		public void RemoveAt(int index) => Children.RemoveAt(index);

		/// <summary>
		/// オブジェクトを削除します。
		/// </summary>
		public void Clear()
		{
			Children.ForEach(child => child.Destroy());
			Children.Clear();
		}

		/// <summary>
		/// 指定したオブジェクトが存在するかどうかを判断します。
		/// </summary>
		public bool Contains(IDrawable item) => Children.Contains(item);

		/// <summary>
		/// 指定した配列およびその位置に、要素をコピーします。
		/// </summary>
		public void CopyTo(IDrawable[] array, int arrayIndex) => Children.CopyTo(array, arrayIndex);

		/// <summary>
		/// 指定したオブジェクトを削除します。
		/// </summary>
		public bool Remove(IDrawable item) => Children.Remove(item);

		/// <summary>
		/// 列挙子を取得します。
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator() => Children.GetEnumerator();

		/// <summary>
		/// 要素数を取得します。
		/// </summary>
		public int Count => Children.Count;

		/// <summary>
		/// 読み取り専用かどうかを示す値を取得します。
		/// </summary>
		public bool IsReadOnly => false;
		#endregion

		private List<IDrawable> Children { get; } = new List<IDrawable>(10000);
	}
}
