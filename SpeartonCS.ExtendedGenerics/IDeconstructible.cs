namespace SpeartonCS.ExtendedGenerics;


/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>
/// </summary>
public interface IDeconstructible<T1, T2>
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>, <typeparamref name="T14"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
	where T14 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14);
}

/// <summary>
/// Deconstruct function with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>, <typeparamref name="T14"/>, <typeparamref name="T15"/>
/// </summary>
public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
	where T14 : allows ref struct
	where T15 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14, out T15 t15);
}
