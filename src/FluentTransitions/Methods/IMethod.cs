﻿namespace FluentTransitions
{
	/// <summary>
	/// Interface for all transition methods
	/// </summary>
	public interface IMethod
	{
		/// <summary>
		/// Called by the Transition framework when its timer ticks to pass in the
		/// time (in ms) since the transition started. 
		/// 
		/// You should return (in an out parameter) the percentage movement towards 
		/// the destination value for the time passed in. Note: this does not need to
		/// be a smooth transition from 0% to 100%. You can overshoot with values
		/// greater than 100% or undershoot if you need to (for example, to have some
		/// form of "elasticity").
		/// 
		/// The percentage should be returned as (for example) 0.1 for 10%.
		/// 
		/// You should return (in an out parameter) whether the transition has completed.
		/// (This may not be at the same time as the percentage has moved to 100%.)
		/// </summary>
		/// <param name="time">The time that has passed</param>
		/// <param name="percentage">Returns the percentage how far the transition has come</param>
		/// <param name="completed">Returns whether the transition has completed or not</param>
		void OnTimer(int time, out double percentage, out bool completed);
	}
}
