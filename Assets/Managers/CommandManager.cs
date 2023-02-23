using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; //use this to easily reverse a list

public class CommandManager : MonoSingleton<CommandManager>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();
    public bool isDone;

    public void AddCommands(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void PlayCommands()
    {     
        StartCoroutine(PlayRoutine());      
    }

    private IEnumerator PlayRoutine()
    {//could also use foreach
           for (int i =0;i<=_commandBuffer.Count-1;i++)
            {
            var command = _commandBuffer[i];
            command.Execute();
            yield return new WaitForSeconds(1);
            }    
    }

    private IEnumerator RewindRoutine()
    {//use a foreach loop and use linq var command in Enumerable.Reverse(_commandBufferer))
        for (int i = _commandBuffer.Count -1; i >= 0; i--)
        {
            var command = _commandBuffer[i];
            command.Undo();
            yield return new WaitForSeconds(1);
        }
    }


    public void RewindCommands()
    {
        StartCoroutine(RewindRoutine());
    }

    public void DoneCommands()
    {//use findgameobjectswithtag to find the cubes so you don't need a public bool
        isDone = true;
       foreach(var command in _commandBuffer)
        {
            command.Execute();           
        }
        isDone = false;
    }

    public void ClearCommands()
    {
        _commandBuffer.Clear();
    }
}
