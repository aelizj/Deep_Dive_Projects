#require_relative "LinkedListInterface"

class Element 
  attr_accessor :value, :next_element

  value = nil
  next_element = nil

  def initialize(value, next_element)
    @value = value
    @next_element = next_element
  end
end

class LinkedList #< LinkedListInterface

  def initialize
    l = LinkedList.new
    is_empty = true
    count = 0
    index = 0
    value = nil
    next_element = nil
  end
   
  def add_value(value)
    if next_element == nil
      next_element = Element.new
      is_empty = false
      
      if count == 0 
        value = first_value
      end

      counter
    else 
      @value.add_value(value)
      counter 
    end
  end

  def get_value(index)
    return LinkedList.index
  end

  def remove_value(index)
    return LinkedList.index.remove
  end

  def next_element

  end

  def first_value
   return first_value
  end

  def last_value
    if LinkedList.next_element == nil
      next_element == last_value
      return last_value
    end
  end

  def counter
    count += 1
    index = count - 1
  end
end