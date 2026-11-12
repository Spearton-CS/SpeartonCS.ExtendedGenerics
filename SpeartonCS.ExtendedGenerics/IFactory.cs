namespace SpeartonCS.ExtendedGenerics;

/// <summary>
/// Factory function for <typeparamref name="TResult"/> without parameters
/// </summary>
public interface IFactory<out TResult>
	where TResult : allows ref struct
{
	public abstract static TResult Factory();
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>
/// </summary>
public interface IFactory<out TResult, in T1>
	where TResult : allows ref struct
	where T1 : allows ref struct
{
	public abstract static TResult Factory(T1 t1);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>, <typeparamref name="T14"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
}

/// <summary>
/// Factory function for <typeparamref name="TResult"/> with parameters: <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>, <typeparamref name="T14"/>, <typeparamref name="T15"/>
/// </summary>
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
	where TResult : allows ref struct
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
	public abstract static TResult Factory(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
}
