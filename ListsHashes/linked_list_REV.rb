class List
  def initialize
    @count = 0 # not needed, you don't need an instance field for this --> EVEN THOUGH WE ADD TO AND SUBTRACT FROM IT?
    @is_empty =  true # not needed, only needed if you have just 1 class 
  end

  def add_value(value)
    if @is_empty == true
      @item = ListItem.new(value)
      @count += 1 
      @is_empty = false  
      @first_value = @item.value # this logic doesn't work if you remove things from the beginning
      return
    else 
      @item.add_item(value)
      @count += 1 
      @last_value = value # this logic doesn't work if you remove things from the end
      return
    end
  end

  def get_value(index)
    if index > @count - 1 || index < 0 # could refactor this into a method since its re-used
      raise IndexError
    end
    @item.get_item(index)
  end

  def remove_value(index)
    if index > @count - 1 || index < 0
      raise IndexError
    end
    a = @item.select_remove_item(index)    
    @item.replace_item(index, a)
    @count -= 1
  end

  def next_element
    if @count > 1
      return @item.next_item
    end
  end

  def first_value
    return @first_value
  end
  
  def last_value
    return @last_value
  end

  def count   
    return @count
  end
end

#----------------------------------------------------
# CLASS CONTAINING LOGIC FOR INDIVIDUAL LIST ITEMS

class ListItem
  attr_accessor :value
  
  def initialize(value = nil)
    @value = value
  end

  def add_item(value)  
    if @next_value == nil
      @next_value = ListItem.new(value)    
    else 
      @next_value.add_item(value) 
    end
  end  

  def get_item(index) 
    if index == 0      
      return @value
    else
      @next_value.get_item(index - 1)      
    end
  end

  def select_remove_item(index) # shouldnt need select and remove 
    if index == 0      
      return @next_value # you don't need the local variable
    else
      @next_value.select_remove_item(index - 1)      
    end
  end

  def replace_item(index, a)
    if (index == 1)
      @next_value = a
    else # what if index is less than 1?  -->  THIS IS ACCOUNTED FOR IN REMOVE_VALUE METHOD ABOVE
      @next_value.remove_item(index - 1, a)      
    end
  end

  def next_item # this has significant functional issues
    l = List.new
    l.add_value(@next_value.value)    
    return l
  end
end

#########################################################################
# c = List.new

# c.add_value("value1")
# c.add_value("value2")
# c.add_value()

# # d = c.next_element
# # p d.first_value

# # p d.next_element

colors = List.new

colors.add_value("azure")
colors.add_value("beige")
colors.add_value("crimson")
colors.add_value("dandelion")
colors.add_value("ecru")
colors.add_value("fuschia")

p colors

p colors.remove_value(1)
p colors


























#>>>>> LINKED LIST REV 03.04.2020 >>>>>
# class List < LinkedListInterface 
#   def initialize
#     @count = 0 # not needed, you don't need an instance field for this
#     @is_empty =  true # not needed, only needed if you have just 1 class
#     #@item
#     #@first_value # you dont need an instance field
#     #@last_value # you don't need an instance field
#   end

#   def add_value(value)
#     if @is_empty == true
#       @item = ListItem.new(value)
#       @count += 1 
#       @is_empty = false  
#       @first_value = @item.value # this logic doesn't work if you remove things from the beginning
#       return
#     else 
#       @item.add_item(value)
#       @count += 1 
#       @last_value = value # this logic doesn't work if you remove things from the end
#       return
#     end
#   end

#   def get_value(index)
#     if index > @count - 1 || index < 0 # could refactor this into a method since its re-used
#       raise IndexError
#     end
#     @item.get_item(index)
#   end

#   def remove_value(index) # COULD BE OPTIMIZED TO BE MORE PERFORMANT
#     if index > @count - 1 || index < 0
#       raise IndexError
#     end
#     a = @item.select_remove_item(index)    
#     @item.remove_item(index, a)
#     @count -= 1
#   end

#   def next_element # NOT COMPLETE
#     #if @count <= 1
#       #List.new # doesnt do anything
#       #return # doesnt do anything
#     #else
#     if @count > 1
#       return @item.next_item
#     end
#   end

#   def first_value
#     return @first_value
#   end
  
#   def last_value
#     return @last_value
#   end

#   def count   
#     return @count
#   end
# end

# #----------------------------------------------------
# # CLASS CONTAINING LOGIC FOR INDIVIDUAL LIST ITEMS

# class ListItem
#   attr_accessor :value
  
#   def initialize(value = nil)
#     @value = value
#   end

#   def add_item(value)  
#     if @next_value == nil
#       @next_value = ListItem.new(value)    
#     else 
#       @next_value.add_item(value) 
#     end
#   end  

#   def get_item(index) 
#     if index == 0      
#       return @value
#     else
#       #index -= 1 # don't need to store the result of the subtration
#       @next_value.get_item(index - 1)      
#     end
#   end

#   def select_remove_item(index) # shouldnt need select and remove 
#     if index == 0      
#       a = @next_value # you don't need the local variable
#       return a
#     else
#       #index -= 1
#       @next_value.select_remove_item(index - 1)      
#     end
#   end

#   def replace_item(index, a) # shouldn't the name be replace_item ? (instead of remove_item)
#     if (index == 1) # index == 1 ?
#       @next_value = a
#     else # what if index is less than 1?
#       #index -= 1
#       @next_value.remove_item(index - 1, a)      
#     end
#   end

#   def next_item # this has significant functional issues
#     l = List.new
#     l.add_value(@next_value.value)    
#     return l
#   end
# end