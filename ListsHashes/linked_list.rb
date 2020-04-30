require_relative "LinkedListInterface"
#--------------------------------------------------
# CLASS CONTAINING LOGIC FOR LIST

class List < LinkedListInterface 
  def initialize
    @count = 0 # not needed, you don't need an instance field for this

    @item
    @last_value # you don't need an instance field
  end

  def add_value(value)
    if @count == 0
      @item = ListItem.new(value)
      @count += 1  
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

  def remove_value(index) # COULD BE OPTIMIZED TO BE MORE PERFORMANT
    if index > @count - 1 || index < 0
      raise IndexError
    end    
    @item.replace_item(index)
    @count -= 1
  end

  def next_element # NOT COMPLETE
    if @count <= 1
      List.new # doesnt do anything
      return # doesnt do anything
    else
      return @item.next_item
    end
  end

  def first_value
    @item.get_first_item
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

  def replace_item(index)
    if index == 1
      @next_value
      @value
      @next_value.replace_item(index - 1)
    elsif index == -1
      p @value
      return
    else
      @value
      @next_value.replace_item(index - 1)      
    end
  end

  def next_item # this has significant functional issues
    l = List.new
    l.add_value(@next_value.value)    
    return l
  end

  def get_first_item
    @value
  end
end

#####################################################
# MORE TESTING OF THE STUFF

colors = List.new

colors.add_value("azure")
colors.add_value("beige")
colors.add_value("crimson")
colors.add_value("dandelion")
colors.add_value("ecru")
colors.add_value("fuschia")
puts

# p colors.get_value(0)
# p colors.get_value(1)
# p colors.get_value(2)
# p colors.get_value(3)
# p colors.get_value(4)
# p colors.get_value(5)
puts

p colors
colors.remove_value(1)
colors.remove_value(5)
# p colors
# puts
# p colors.get_value(0)
# p colors.get_value(1)
# p colors.get_value(2)
# p colors.get_value(3)
# p colors.get_value(4)
# p colors.get_value(5)
p colors
puts
p colors.get_value(0)
p colors.get_value(1)
p colors.get_value(2)
p colors.get_value(3)
p colors.get_value(4)
p colors.get_value(5)

# c = List.new

# c.add_value("value1")
# c.add_value("value2")

# d = c.next_element
# p d.first_value


# b = List.new
#  b.add_value("cat")
#  b.add_value("dog")
#  b.add_value("parrot")
#  b.add_value("fish")
#  p b  
#  puts ""

# p b.next_element


# # p "COUNT = #{b.count}"
# p b.get_value(0)
# p b.get_value(1)
# p b.get_value(2)
# p b.get_value(3)
# p b.get_value(-1)
# p b.get_value(25)


# b.first_value
# b.last_value
# b.next_element

# puts ">>>> ORIGINAL LIST:"
# p b
# puts ""

# b.remove_value(2)
# b.last_value

# puts ">>>> NEW LIST AFTER REMOVING ITEM:"
# p b


#####################################################
# TESTING THE STUFF 


# p a = List.new
# puts ""

# p "#-------- ADDING FIRST THING -----------#"
# a.add_value("thing 1")
# p a
# puts ""

# p "#--------- ADDING SECOND THING ----------#"
# a.add_value("thing 2")
# p a 
# puts ""

# p "#---------ADDING THIRD THING ----------#"
# a.add_value("thing 3")
# p a 
# puts ""

# p "#---------ADDING FOURTH THING ----------#"
# a.add_value("thing 4")
# p a 
# puts ""

# p "#---------ADDING FIFTH THING ----------#"
# a.add_value("thing 5")
# p a 
# puts ""

# p "#---------ADDING SIXTH THING ----------#"
# a.add_value("thing 6")
# p a 
# puts ""


# p a.first_value
# p a.last_value
# puts ""


# p a.get_value(0)
# p a.get_value(1)
# p a.get_value(2)
# p a.get_value(3)
# p a.get_value(4)
# p a.get_value(5)

#######################################################
#Feb 2020 Rev - for reference 

# require_relative "LinkedListInterface"
# #--------------------------------------------------
# # CLASS CONTAINING LOGIC FOR LIST

# class List < LinkedListInterface 
#   def initialize
#     @count = 0 # not needed, you don't need an instance field for this
#     @is_empty =  true # not needed, only needed if you have just 1 class
#     @item
#     @first_value # you dont need an instance field
#     @last_value # you don't need an instance field
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
#     a = @item.select_replace_item(index)    
#     @item.replace_item(index, a)
#     @count -= 1
#   end

#   def next_element # NOT COMPLETE
#     if @count <= 1
#       List.new # doesnt do anything
#       return # doesnt do anything
#     else
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
#       @next_value.get_item(index - 1)      
#     end
#   end

#   def select_replace_item(index) # shouldnt need select and remove 
#     if index == 0      
#       a = @next_value # you don't need the local variable
#       return a
#     else
#       index -= 1
#       @next_value.select_replace_item(index)      
#     end
#   end

#   def replace_item(index, a) # shouldn't the name be replace_item ?
#     if (index - 1) == 0 # index == 1 ?
#       @next_value = a
#     else # what if index is less than 1?
#       index -= 1
#       @next_value.replace_item(index - 1, a)      
#     end
#   end

#   def next_item # this has significant functional issues
#     l = List.new
#     l.add_value(@next_value.value)    
#     return l
#   end
# end

#######################################################
# PREVIOUS ATTEMPT - ONE CLASS (FOR PERSONAL REFERENCE)


#   def initialize(value = nil, next_value = nil)
#     @next_value = next_value
#     @value = value
#     @count = count = 0
#   end

#   def add_value(value)
#     p ">>> BEGINNING OF ADD_VALUE METHOD <<<"
#     if @next_value == nil
#       @next_value = List.new(value)
#       @count += 1
#       p "IF STATEMENT EXECUTED"
#     else 
#       @next_value.add_value(value)
#       @count += 1
#       p "ELSE STATEMENT EXECUTED"
#     end
#   end
  
#   def get_value(index)
#   end

#   def remove_value(index)
#   end

#   def next_element
#   end

#   def count
#   end

#   def first_value
#   end

#   def last_value
#   end
# end

# p a = List.new
# p a.add_value("thing") 
# p a
# p "First element added!\n"
# p a.add_value("stuff")
# p "Second element added!\n"
# p a


#######################################################
# PREVIOUS ATTEMPT - ONE CLASS (FOR PERSONAL REFERENCE)


# class List < LinkedListInterface
 
#     @value = value = nil
#     @next_element = nil
#     @count = 0
#     @first_value = nil
#     @last_value = nil
#     @is_empty = true
#     @index = index = 0

#   def add_value(value)
#     if @next_element == nil
#       @next_element = List.new
#       index = index += 1
#       @is_empty = false

#       p "Value = #{value}"
#       p "Next Element = #{@next_element}"
#       p "Counter = #{@counter}"
#       p "First Value = #{@first_value}"
#       p "Last Value = #{@last_value}"
#       p "Is Empty? = #{@is_empty}"
#       p "Index = #{index}"
#       puts ""
#       puts "IF STATEMENT EXECUTED"

#     else 
#       @next_element.add_value(value)
#       index += 1

#       p "Value = #{value}"
#       p "Next Element = #{@next_element}"
#       p "Counter = #{@counter}"
#       p "First Value = #{@first_value}"
#       p "Last Value = #{@last_value}"
#       p "Is Empty? = #{@is_empty}"
#       p "Index = #{index}"
#       puts ""
#       puts "ELSE STATEMENT EXECUTED"
#     end
#   end

#   def get_value(index)
#     return List.index
#   end

#   def remove_value(index)
#     List.index.remove
#   end

#   def next_element
#   end

#   def first_value   
#   end

#   def last_value
#   end

#   def counter
#     #@count = @count + 1    
#   end

# end


####################################################