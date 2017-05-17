# PreviousData-Binding-Issue
I tried to use `{RelativeSource PreviousData}` in a `ListBox.ItemTemplate` and it worked correctly.

But, when using the specific code provided below, binding stops working when scrolling up an down few times and **some** of the `Rectangle`s are missing.

The issue reproduce even when using a single `DataTrigger`, but it does **not** reconstruct when `ListBox.Height` is more than **178**. 

#Example GIF:

[![Regular scroll works, but fast scroll cause it binding to 'loose-it'][1]][1]


  [1]: https://i.stack.imgur.com/wvhXS.gif
  
  
#Stackoverflow link:
http://stackoverflow.com/questions/44005571/binding-relativesource-previousdata-breaks-binding-in-specific-case

if you have any idea what causing it - that would be great :-)
